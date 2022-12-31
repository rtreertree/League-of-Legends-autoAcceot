import glob
import os

print('start')
image_list = []
for filename in glob.glob('*.jpg'):
    filename_split = filename.replace('.jpg', '').split('_')
    if (int(filename_split[1]) > 0):
        os.remove(filename)
        continue
    print(filename_split)