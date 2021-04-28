import os
import vlc
import time
import sys




def playsong(song):
 print(song)
 p=vlc.MediaPlayer(song)
 p.audio_set_volume(100)
 p.play()
 time.sleep(2)
 duration=p.get_length()/1000
 print(duration)
 print(p.get_state()) 
 print(p.audio_get_volume())
 time.sleep(duration)
 p.stop()   
     


playsong(sys.argv[1])
    
