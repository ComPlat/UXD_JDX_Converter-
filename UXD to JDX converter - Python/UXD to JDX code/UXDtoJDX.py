from tkinter import filedialog
import tkinter as tk
import os
from bs4 import BeautifulSoup 


root = tk.Tk()
root.withdraw()

my_filetypes = [('UXD files', '.uxd'), ('all files', '.*')]
filePath = filedialog.askopenfilename(master=root, initialdir=os.getcwd(), title="Please select a file:", filetypes=my_filetypes)
inputFile = open(filePath, 'r')
outputFile = open(filePath[:-4]+'.jdx', 'a+')
outputFile.truncate(0)

__location__ = os.path.realpath(os.path.join(os.getcwd(), os.path.dirname(__file__)))
xmlFile = open(os.path.join(__location__, "config.xml"), 'r')
bs_data = BeautifulSoup(xmlFile, 'xml') 

lines = inputFile.readlines()
num_container = []
initiator = [
    f'##TITLE={bs_data.find("title").text}',
    f'##JCAMP-DX={bs_data.find("JCAMP").text}',
    f'##DATA TYPE={bs_data.find("datatype").text}',
    f'##DATA CLASS={bs_data.find("dataclass").text}',
    f'',
    f'##ORIGIN={bs_data.find("origin").text}',
    f'##OWNER={bs_data.find("owner").text}'
    f'',
    f''
]

for text in initiator:
    outputFile.write(text + '\n')

for line in lines:
    if line[0] == '_' and line[1] != '+':
        data = line.split('=')
        name = data[0].strip()[1:]
        variable = data[1].strip().replace('\n', '')
        
        output = '##' + name + ' = ' + variable + '\n'
        outputFile.write(output)

    elif line[0] == '_':
        name = line.strip()[1:]

        output = '##' + name + '\n'
        outputFile.write(output)

    else:
        try: 
            int(line[0:2])
            if '	' in line:
                data = line.split('	')
            elif ',' in line:
                data = line.split(',')
            num1 = data[0].strip()
            num2 = data[1].strip()
            num_container.append((num1, num2))
        except:
            pass
outputFile.write('\n\n')

#Minimum Value in First & Second Columns
min_col_1 = num_container[0][0]
min_col_2 = num_container[0][1]

max_col_1 = num_container[0][0]
max_col_2 = num_container[0][1]
for nums in num_container:
    if float(nums[0]) < float(min_col_1):
        min_col_1 = nums[0]
    
    if float(nums[1]) < float(min_col_2):
        min_col_2 = nums[1]

    if float(nums[0]) > float(min_col_1):
        max_col_1 = nums[0]
    
    if float(nums[1]) > float(min_col_2):
        max_col_2 = nums[1]

num_analysis = [
    '##FIRSTX='+num_container[0][0],
    '##LASTX='+num_container[-1][0],
    '##MINX='+min_col_1,
    '##MAXX='+max_col_1,
    '##MINY='+min_col_2,
    '##MAXY='+max_col_2,
    '##NPOINTS='+str(len(num_container)),
    '##FIRSTY='+num_container[0][1],
    f'##XUNITS={bs_data.find("x-units").text}',
    f'##YUNITS={bs_data.find("y-units").text}',
    f'##XYPOINTS={bs_data.find("XYPOINTS").text}'
]

for item in num_analysis:
    outputFile.write(item + '\n')

for item in num_container:
    data = '\n' + item[0] + '	' + item[1]
    outputFile.write(data)

outputFile.write('\n' + '##END=$$ End of the data block')
    
print('successful conversion!')
print(f'New File: {filePath[:-4]+".jdx"}')
