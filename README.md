
# Enigma

![alt text](https://github.com/caadam/enigma/blob/master/Images/enigma_logo.jpg "Enigma Logo")

# 1 Introduction

## 1.1History

The Enigma machines were a series of electro-mechanical rotor cipher machines developed and used in the early- to mid-twentieth century to protect commercial, diplomatic and military communication. Enigma was invented by the German engineer Arthur Scherbius at the end of World War I. Early models were used commercially from the early 1920s, and adopted by military and government services of several countries, most notably Nazi Germany before and during World War II. Several different Enigma models were produced, but the German military models are the most commonly recognised.


![alt text](https://github.com/caadam/enigma/blob/master/Images/m3_engima_machine.jpg "M3 Enigma Machine")
Credit : [https://en.wikipedia.org/wiki/Enigma\_machine](https://en.wikipedia.org/wiki/Enigma_machine)

Figure 1: M3 Enigma Machine. credit : www.cryptomuseum.com

## 1.2 Relevance

The Enigma machine, while flawed, was sufficiently complex that it couldn&#39;t be cracked efficiently, reliably and most importantly, in a timely manner by humans. The solution was an electro-mechanical machine called a Bombe which set the foundation for modern computers and the concepts of programming. The Bombe and it&#39;s crypt-analysis techniques subsequently contributed to the creation of Colossus, the world&#39;s first digital, programmable computer. Attacking the Enigma was the driver for modern computing.

## 1.3 Key objectives

This project represents a tool to measure your current level of developer skills. We are looking at both your technical skills and professional soft skills. Specifically, we will be monitoring and guiding you in the following areas:

- Technical Skills. Whatever your current skill level, we&#39;ll make you better. As you progress we will review your code and provide feedback and suggest changes.
- Managing complexity. Junior developers often attempt to solve a problem in an overly complex way. A simple and clean solution is a better solution.
- Ability to manage your time and client timeframes. We need to you start understanding your time and that of your mentor(s) is finite and has a significant dollar value attached to it. We need you to learn to manage your time, manage deadlines and be efficient.
- Your ability to communicate. You&#39;ll have to communicate back to your mentors about your progress and your understanding of the Enigma problem.
- Using failure to your advantage. We want you to fail fast and learn.
- Just in time learning. Chances are you won&#39;t have all the skills you need to implement this project to a level we&#39;ll be happy with. You&#39;ll have to learn &#39;on-the-job&#39; through whatever mechanism works for you. This is an essential skill for your future success at Microsoft.

### 1.3.1 Understand a complex problem

The Enigma machine represents a complex mechanical device that translates well into code. You are expected to learn and understand the components of an Enigma machine and how they physically operate. Specifically, you will learn the inner workings of a M3/M4 German Enigma machine.

### 1.3.2 Decompose a complex problem into implementable steps

Once you understand the problem, you need to decompose it into units of work that are able to be implemented in code. We ask that you solve this in an object-orientated manner as it will align most closely with how our customers operate. You are not being asked to implement or prove the mathematical efficiency of your solution.

### 1.3.3 Develop to be testable and verifiable

Your solution must be built to be testable. We recommended taking a TDD (Test Driven Development) approach however you are welcome to challenge that and propose an alternative. Not negotiable is that your code will be unit tested and have 100% code coverage. This document will provide actual, historical, German encrypted messages, their settings and the validated decrypt for final testing. These MUST be used as part of your unit testing. If you can&#39;t prove your code works through unit-testing then it doesn&#39;t work – NOT NEGOTIALBLE.

### 1.3.4 Be efficient

You are a graduate and you got this job because we saw raw talent and passion in you. It&#39;s now time to lose the ego and learn to operate in a professional environment. Regardless of how good you think you may be, you have a lot to learn. You aren&#39;t being graded on completion of this project at an arbitrary date. Your objective is to complete this project as fast as possible against the provided requirements and objects. Time is money in the commercial world. This means, if you are stuck, swallow our pride and ask for help. Your mentors want you to FAIL FAST, FAIL OFTEN and ask for help. This is the best way to learn and aligns with modern development practices.

### 1.3.5 Don&#39;t break the build

One of the golden rules in development is that you never commit code that will break the build for other developers. The reason being, is that a broken build blocks EVERYONE on a team. It is time consuming and expensive for a team to fix a broken build.

## 1.4 Requirements

You must use the following technologies during this project

- Latest version of Visual Studio available
- C#
- Latest version of the .Net framework available
- TFVC or GIT version control inside VSTS
- Microsoft Test Framework
- Estimation and task planning is to be done using VSTS

In additional to meeting the technical requirements, you must also meet demonstrate that you have:

- Planned your project and broken into task inside VSTS
- Documented your code including providing pseudo code for any complex functionality

## 1.5 Success Criteria

Aside from meeting the aforementioned objectives, your enigma machine must be able to decode the following message.

Message

DLWF FWEG JXUY PMDI UWGM EGXW AYB-

Reflector: Thin C

Wheel order: γ (Gamma) V I III

Ringstellung: CODE

Ring positions: 16 09 13 16

Plug pairs: AY BF DL GX HZ NS OC QT RJ VP

## 1.6 Alternate Challenge

If you feel this challenge isn&#39;t hard enough for you, the alternate option is to implement in software, the Bombe machine to crack enigma messages. Requirements and objectives remain unchanged. Your success criteria is to decrypt the following encrypted message.

Message

QMFK NJBB JLOS MGXC JKRH EVTG XBG-

No encryption settings are provided

# 2 Problem

The following details the setup and mechanical operation of an Enigma machine. Like dealing with a real world client, it may or may not provide sufficient, accurate or sufficient information for you to complete the project. If you feel further information or clarification is required, please either search for the details from the internet or directly ask your client - A.K.A your mentor.

## 2.1 Components

The following image shows the basic components of an enigma machine. They will be individually described in detail in subsequent sections.

![alt text](https://github.com/caadam/enigma/blob/master/Images/engima_components.jpg "Enigma components")
Figure 2: Enigma Machine. credit : www.cryptomuseum.com

## 2.2 Basic Operation

An enigma machine was operated by a single individual and an optional radio operator to help. The individual would first setup the machine using a known configuration that was changed daily and kept in codebook.

![alt text](https://github.com/caadam/enigma/blob/master/Images/codebook.jpg "Codebook page from October 1944")
Figure 3: Codebook page from October 1944

Once a machine was setup, the operator typed the message into the machine and recorded the result on the lampboard. Because the enigma machine uses a symmetrical algorithm, the same initial setup was used for encoding and decoding.

For each character that is pressed, the machine first increments one or more rotors. Once a new circuit is complete, the encoded/decoded character is illuminated on the lampboard. The following diagram demonstrates the complete circuit from Keyboard through plugboard, rotors, reflectors then back before illuminating a lamp on the lampboard.

![alt text](https://github.com/caadam/enigma/blob/master/Images/physical_diagram.png "Physical connections in the Enigma machine")
Figure 4 : Physical connections in the Enigma machine

## 2.3 Keyboard

The keyboard on the enigma machine was a 26 character QWERTY layout. A key press would first increment the rotors, then complete the circuit and illuminate the encoded character on the lampboard.

![alt text](https://github.com/caadam/enigma/blob/master/Images/keyboard.png "Enigma Keyboard")
Figure 5 : Enigma Keyboard

## 2.4 Plugboard (Steckerbrett)

The plugboard was a component that remapped up to 10 characters and was the second element during encoding/decoding. The characters where mapped by physically connecting plugs and wires from the inbound character to the outbound. A character and be used for a mapped pair only once. The plugboard was added to military Engima machines to provide and extra level of security to messages.

![alt text](https://github.com/caadam/enigma/blob/master/Images/plugboard.png "Enigma Plugboard")
Figure 6 : Enigma Plugboard

## 2.5 Scrambler Unit

The scrambler unit was the major component of the enigma machine. It was made up of an entry wheel, 3 or 4 rotors and a reflector. The rotors and reflectors are able to be changed by the user. The use is also able to set the starting position of each rotor after installation. The choice of rotors, reflector and rotor position was defined by the codebook.

![alt text](https://github.com/caadam/enigma/blob/master/Images/scrambler.jpg "Scrambler unit showing rotors and reflectors")
Figure 7 : Scrambler unit showing rotors and reflectors

Once a key was pressed on the keyboard, the scrambler incremented one or more of the rotor position to form a new connection path way. The path on a 3 rotor machine was as follows:

1. ETW (Entry Wheel / Static Rotor)
2. Rotor 1 (right)
3. Rotor 2 (middle)
4. Rotor 3 (left)
5. Reflector
6. Rotor 3 (left)
7. Rotor 2 (middle)
8. Rotor 1 (right)
9. ETW (Entry Wheel / Static Rotor)

A 4 rotor machine has a further rotor between Rotor 3 and the Reflector.

### 2.5.1 Static Rotor (ETW)

The static rotor acted as a coupling device between the plugboard and the rotating components of the scrambler unit. It did not remap any characters.

### 2.5.2 Rotors

The rotors, also referred to as wheels, are the core component of the Enigma machine. Each wheel remaps the inbound pin to an outbound pin. Each rotor was identified by a roman numeral or greek character. Each Enigma machine type of Enigma machine carried a duplicate set of rotors. The exact rotors carried changed over time.

The following shows the internal workings of a rotor.

![alt text](https://github.com/caadam/enigma/blob/master/Images/rotor.png "Exploded view of a Rotor")
Figure 8 : Exploded view of a Rotor

#### 2.5.2.1 Internal Wiring (Mapping)
The mappings for each rotor are defined below.

| Rotor | Mapping (ABCDEFGHIJKLMNOPQRSTUVWXYZ) | Notch | Turnover |
| --- | --- | --- | --- |
| I | EKMFLGDQVZNTOWYHXUSPAIBRCJ | Y | Q |
| II | AJDKSIRUXBLHWTMCQGZNPYFVOE | M | E |
| III | BDFHJLCPRTXVZNYEIWGAKMUSQO | D | V |
| IV | ESOVPZJAYQUIRHXLNFTGKDCMWB | R | J |
| V | VZBRGITYUPSDNHLXAWMJQOFECK | H | Z |
| VI | JPGVOUMFYQBENHZRDKASXLICTW | HU | ZM |
| VII | NZJHGRCXMYSWBOUFAIVLPEKQDT | HU | ZM |
| VIII | FKQHTLXOCBJSPDZRAMEWNIUYGV | HU | ZM |
| Beta | LEYJVCNIXWPBQMDRTAKZGFUHOS |   |   |
| Gamma | FSOKANUERHMBTIYCWLQPZXVGJD |   |   |

Table 1 : Rotor wiring

#### 2.5.2.2 Rotor Settings

For the Enigma machine to correctly decode or encode a message, it required the rotors to be setup based on the daily settings found in the codebook. The following are the settings for the rotors.

##### 2.5.2.2.1 Ring settings (Ringstellung)

Each rotor has a ring (see figure 8 above) with either characters (A-Z) or numbers (1-26). Initially A or 1 is aligned to pin 1 however it can be rotated to other position as defined in the Ringstellung. If a rotor had a ringstellung of 3 or C, it meant rotating the ring 3 increments from the back to the front. A Ringstellung of &#39; **XMV**&#39; or &#39; **24,13,22**&#39; meant incrementing the left rotors ring **24** positions, the middle rotors ring **13** positions and the right rotors ring **22** positions.

##### 2.5.2.2.2 Rotor Position (Walzenlage)

Each rotor need to be installed into the correct position in the scrambler. The notation for rotor position was read left to right visually matched the physical machine. For example, a rotor position setting of &#39; **II V III**&#39; means that rotor **II** is installed in the left most position, rotor **V** in the middle and rotor **III** in the right most position.

##### 2.5.2.2.3 Start Position (Grundstelling)

Once the rotors had their ring positions set and installed in the correct position, they can be manually incremented to their starting position. A start position of &#39; **ABL**&#39; meant that the left most rotor was left in position A, the middle rotor was rotated to position B was visible and the right most rotor was rotated until L was visible.

![alt text](https://github.com/caadam/enigma/blob/master/Images/rotor_start_position.png "Windows showing the starting positon of rotors on a M4 Enigma machine")
Figure 9 : Windows showing the starting positon of rotors on a M4 Enigma machine

#### 2.5.2.3 Stepping

At each keypress, a ratchetting mechanism in the machine incremented the right most rotor by a single position. Most rotors also had one or two turn over points. If a rotor reached a turnover point, the rotor to its left would increment by a single position on the next key-press.

| Rotor | Notch | Effect |
| --- | --- | --- |
| I | Q | If rotor steps from Q to R, the next rotor is advanced |
| II | E | If rotor steps from E to F, the next rotor is advanced |
| III | V | If rotor steps from V to W, the next rotor is advanced |
| IV | J | If rotor steps from J to K, the next rotor is advanced |
| V | Z | If rotor steps from Z to A, the next rotor is advanced |
| VI, VII, VIII | Z+M | If rotor steps from Z to A, or from M to N the next rotor is advanced |

Table 2 : Effect or Rotor Notch

In the following examples you can observe a normal step sequence and a double step sequence. The used rotors are (from left to right) I, II, III, with turnovers on Q, E and V. It is the right rotor&#39;s behavior we observe here (turnover V).

##### 2.5.2.3.1 Single Step

| Rotor positions | Effect |
| --- | --- |
| AAU | normal step of right rotor |
| AAV | right rotor (III) goes in V—notch position |
| ABW | right rotor takes middle rotor one step further |
| ABX | normal step of right rotor |

##### 2.5.2.3.2 Double Step

| Rotor positions | Effect |
| --- | --- |
| ADU | normal step of right rotor |
| ADV | right rotor (III) goes in V—notch position |
| AEW | right rotor steps, takes middle rotor (II) one step further, which is now in its own E—notch position |
| BFX | normal step of right rotor, double step of middle rotor, normal step of left rotor |
| BFY | normal step of right rotor |

### 2.5.3 Reflector

Like the rotors, the reflector remapped an input character to an output character however it&#39;s output was returned back to the rotors, &#39;reflecting&#39; the current back along the circuit. The operator selected and installed based on the codebook settings for the day.

The following are the reflector names and their mappings.

| Reflector | Mapping (ABCDEFGHIJKLMNOPQRSTUVWXYZ) |
| --- | --- |
| Reflector A | EJMZALYXVBWFCRQUONTSPIKHGD |
| Reflector B | YRUHQSLDPXNGOKMIEBFZCWVJAT |
| Reflector C | FVPJIAOYEDRZXWGCTKUQSBNMHL |
| Reflector B Thin | ENKQAUYWJICOPBLMDXZVFTHRGS |
| Reflector C Thin | RDOBJNTKVEHMLFCWZAXGYIPSUQ |

Table 3 : Reflector Mappings

## 2.6 Lampboard

The final part of the circuit is a bulb located on the lampboard. The lampboard was laid out in the same, 26 character QWERTY layout as the keyboard.

![alt text](https://github.com/caadam/enigma/blob/master/Images/lampboard.png "Enigma machine lampboard")
Figure 10 : Enigma machine lampboard

1.
# 3 Sample Data

The following are actual German encryptions, their settings and validated decrypts that can be used for testing.

## 3.1 M3 Enigma

## 3.1.1 Enigma Instruction Manual 1930

**Encrypted Message**

GCDSE AHUGW TQGRK VLFGX UCALX VYMIG MMNMF DXTGN VHVRM MEVOU YFZSL RHDRR XFJWC FHUHM UNZEF RDISI KBGPM YVXUZ

**Decrypted Message**

FEIND LIQEI NFANT ERIEK OLONN EBEOB AQTET XANFA NGSUE DAUSG ANGBA ERWAL DEXEN DEDRE IKMOS TWAER TSNEU STADT

**Settings**

Reflector: A

Wheel order: II I III

Position:ABL

Ring positions: X(24) M(13) V(22)

Plug pairs: AM FI NV PS TU WZ

German: Feindliche Infanterie Kolonne beobachtet.Anfang Südausgang Bärwalde. Ende 3km ostwärts Neustadt.

English: Enemy infantry column was observed.Beginning[at] southern exit[of] Baerwalde. Ending 3km east of Neustadt.

### 3.1.2 Operation Barbarossa 1941

**Encrypted Message Part 1**

EDPUD NRGYS ZRCXN UYTPO MRMBO FKTBZ REZKM LXLVE FGUEY SIOZV EQMIK UBPMM YLKLT TDEIS MDICA GYKUA CTCDO MOHWX MUUIA UBSTS LRNBZ SZWNR FXWFY SSXJZ VIJHI DISHP RKLKA YUPAD TXQSP INQMA TLPIF SVKDA SCTAC DPBOP VHJK-

**Decrypted Message**

AUFKL XABTE ILUNG XVONX KURTI NOWAX KURTI NOWAX NORDW ESTLX SEBEZ XSEBE ZXUAF FLIEG ERSTR ASZER IQTUN GXDUB ROWKI XDUBR OWKIX OPOTS CHKAX OPOTS CHKAX UMXEI NSAQT DREIN ULLXU HRANG ETRET ENXAN GRIFF XINFX RGTX-

**Settings**

Reflector: B

Wheel order: II IV V

Ringstellung: BLA

Ring positions: 02 21 12

Plug pairs: AV BS CG DL FU HZ IN KM OW RX

**Encrypted Message Part 2**

SFBWD NJUSE GQOBH KRTAR EEZMW KPPRB XOHDR OEQGB BGTQV PGVKB VVGBI MHUSZ YDAJQ IROAX SSSNR EHYGG RPISE ZBOVM QIEMM ZCYSG QDGRE RVBIL EKXYQ IRGIR QNRDN VRXCY YTNJR

**Decrypted Message**

DREIG EHTLA NGSAM ABERS IQERV ORWAE RTSXE INSSI EBENN ULLSE QSXUH RXROE MXEIN SXINF RGTXD REIXA UFFLI EGERS TRASZ EMITA NFANG XEINS SEQSX KMXKM XOSTW XKAME NECXK

**Settings**

Reflector: B

Wheel order: II IV V

Ring positions: 02 21 12

Ringstellung: LSD

Plug pairs: AV BS CG DL FU HZ IN KM OW RX

German: Aufklärung abteilung von Kurtinowa nordwestlich Sebez[auf] Fliegerstraße in Richtung Dubrowki, Opotschka. Um 18:30 Uhr angetreten angriff.Infanterie Regiment 3 geht langsam aber sicher vorwärts. 17:06 Uhr röm eins InfanterieRegiment 3 auf Fliegerstraße mit Anfang 16km ostwärts Kamenec.

English: Reconnaissance division from Kurtinowa north-west of Sebezh on the flight corridor towards Dubrowki, Opochka.Attack begun at 18:30 hours.Infantry Regiment 3 goes slowly but surely forwards. 17:06 hours[Roman numeral I ?] Infantry Regiment 3 on the flight corridor starting 16 km east of Kamenec.

### 3.1.3 Scharnhorst 1943

**Encrypted Message**

YKAE NZAP MSCH ZBFO CUVM RMDP YCOF HADZ IZME FXTH FLOL PZLF GGBO TGOX GRET DWTJ IQHL MXVJ WKZU ASTR

**Decrypted Message**

STEUE REJTA NAFJO RDJAN STAND ORTQU AAACC CVIER NEUNN EUNZW OFAHR TZWON ULSMX XSCHA RNHOR STHCO

**Settings**

Reflector: B

Wheel order: III VI VIII

Ring positions: 01 08 13

Plug pairs: AN EZ HK IJ LR MQ OT PV SW UX

Ringstellung: UZV

German: Steuere Tanafjord an.Standort Quadrat AC4992, fahrt 20sm.Scharnhorst. [hco - padding ?]

English: Heading for Tanafjord.Position is square AC4992, speed 20 knots.Scharnhorst.

## 3.2 M4 Enigma

## 3.2.1 U264 1942

**Encrypted Message**

NCZW VUSX PNYM INHZ XMQX SFWX WLKJ AHSH NMCO CCAK UQPM KCSM HKSE INJU SBLK IOSX CKUB HMLL XCSJ USRR DVKO HULX WCCB GVLI YXEO AHXR HKKF VDRE WEZL XOBA FGYU JQUK GRTV UKAM EURB VEKS UHHV OYHA BCJW MAKL FKLM YFVN RIZR VVRT KOFD ANJM OLBG FFLE OPRG TFLV RHOW OPBE KVWM UQFM PWPA RMFH AGKX IIBG

**Decrypted Message**

VONV ONJL OOKS JHFF TTTE INSE INSD REIZ WOYY QNNS NEUN INHA LTXX BEIA NGRI FFUN TERW ASSE RGED RUEC KTYW ABOS XLET ZTER GEGN ERST ANDN ULAC HTDR EINU LUHR MARQ UANT ONJO TANE UNAC HTSE YHSD REIY ZWOZ WONU LGRA DYAC HTSM YSTO SSEN ACHX EKNS VIER MBFA ELLT YNNN NNNO OOVI ERYS ICHT EINS NULL

**Settings**

Reflector: Thin B

Wheel order: β II IV I

Ringstellung: VJNA

Ring positions: 01 01 01 22

Plug pairs: AT BL DF GJ HM NW OP QY RZ VX

German: Von Von &#39;Looks&#39; F T 1132/19 Inhalt: Bei Angriff unter Wasser gedrückt, Wasserbomben.Letzter Gegnerstandort 08:30 Uhr Marine Quadrat AJ9863, 220 Grad, 8sm, stosse nach. 14mb fällt, NNO 4, Sicht 10.

English: From Looks, radio-telegram 1132/19 contents: Forced to submerge under attack, depth charges. Last enemy location 08:30 hours, sea square AJ9863, following 220 degrees, 8 knots. [Pressure] 14 millibars falling, [wind] north-north-east 4, visibility 10.

# 4 References

[https://en.wikipedia.org/wiki/Enigma\_machine](https://en.wikipedia.org/wiki/Enigma_machine)

[https://en.wikipedia.org/wiki/Enigma\_rotor\_details](https://en.wikipedia.org/wiki/Enigma_rotor_details)

[http://wiki.franklinheath.co.uk/index.php/Enigma/Sample\_Messages](http://wiki.franklinheath.co.uk/index.php/Enigma/Sample_Messages)

[http://www.cryptomuseum.com/crypto/enigma](http://www.cryptomuseum.com/crypto/enigma)

[https://www.youtube.com/watch?v=G2\_Q9FoD-oQ](https://www.youtube.com/watch?v=G2_Q9FoD-oQ)

[https://www.youtube.com/watch?v=V4V2bpZlqx8](https://www.youtube.com/watch?v=V4V2bpZlqx8)

[https://www.youtube.com/watch?v=d2NWPG2gB\_A](https://www.youtube.com/watch?v=d2NWPG2gB_A&amp;index=1&amp;list=PLTGL4f4L0N_zk7ZbeM_XqGU7ZHJWJfQba)

[https://www.youtube.com/watch?v=kj\_7Jc1mS9k](https://www.youtube.com/watch?v=kj_7Jc1mS9k)

[http://www.enigma.hoerenberg.com/index.php?cat=Norrk%C3%B6ping%20messages](http://www.enigma.hoerenberg.com/index.php?cat=Norrk%C3%B6ping%20messages)