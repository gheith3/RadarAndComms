COMMS AND RADAR CALCULATOR


In the age of technological advancement, precision in communication and
radar systems has become indispensable. This research report details the
development of a comprehensive mobile application designed to facilitate
radar and communication system calculations. The application encompasses
four vital calculators: Line of Sight (LOS) Distance Calculator,
Receiver Sensitivity Analysis, Free Space Loss (FSL) Calculator, and
Maximum Detection Range Estimation Calculator. These calculators have
been meticulously designed to provide accurate and efficient solutions
to challenges in radar technology and communication systems.

#    INTRODUCTION

## Introduction

In the field of radar and communication systems, complex calculations
are often required to determine the feasibility and budgeting of various
projects. These calculations involve multiple parameters and variables
that need to be carefully considered. To simplify this process, a radar
and communication links budget tool has been developed. This tool aims
to streamline the calculation process and provide accurate results,
enabling engineers and project managers to make informed decisions.

With the advent of mobile applications, professionals are able to access
information and perform complex calculations more efficiently and
effectively. Our application was developed to meet the specific needs of
radar technology and communication systems professionals. Users are able
to perform critical tasks with precision and ease through the intuitive
interface which houses four essential calculators.

In this study, the methodology employed in developing these calculators
is examined. These calculators were designed to produce accurate results
while being user-friendly and applicable to real-world situations. In
order to accomplish this monumental project, the C# programming language
has been chosen for its versatility, reliability, and performance \[1\].
The C# programming language provides a robust foundation for a
user-friendly, yet highly capable tool that is flexible, yet highly
functional. This visionary app can be brought to life with its
adaptability, which makes it the ideal choice.

The following sections of this report provide comprehensive explanations
and examples of each application feature, detailing the methodology and
formula behind these features. A comprehensive overview of the project
will also be presented, highlighting its potential impact on
communication and radar systems.

#    LITERATURE REVIEW

## Introduction

In order to develop our research methodology, we conducted a thorough
literature review encompassing LOS calculations, radar technology,
communication systems, and electromagnetic theory. Our findings from the
literature review were summarized as follows:

1.  LOS Calculations: Calculation of LOS distances requires accurate
    height measurements and geometry and trigonometry principles \[2\].

2.  Sensitivity Analysis of the Receiver: An analysis of the *SNR*
    (signal to noise ratio) and noise figure (noise figure) revealed a
    significant relationship between bandwidth, noise floor, and
    receiver sensitivity \[3\].

3.  Free Space Loss (FSL): The literature emphasizes electromagnetic
    theory and propagation models and emphasizes Friis\'s transmission
    equation for FSL calculations \[4\].

4.  Estimation of maximum detection range: Radar fundamentals, including
    transmitter power, antenna gain, RCS, and sensitivity, have been
    identified as critical components of range estimation \[5\], \[6\].

#    RESEARCH METHODOLOGY

## Introduction

In the developing stages of the mobile application for communication and
radar system calculations, a systematic research methodology was
utilized. This section provides insight into the approach we adopted to
comprehend and implement each calculator within the application.
Additionally, the key formulas used are as described:

## Line of Sight (LOS) Distance

1.  Geometry and Trigonometry: The development process of the radar and
    target Line Of Sight (LOS) distance calculator begins with a
    foundational understanding of geometry and trigonometry. These
    mathematical principles are crucial for calculating LOS distances
    accurately.

2.  Consultation with Experts: To ensure the precision of LOS distance
    calculations, consultations were held with experts in relevant
    fields, including radar technology and geometry.

3.  Literature Review: A comprehensive literature review was conducted,
    covering resources related to LOS calculations and radar systems.
    This review helped in identifying common methodologies and best
    practices.

The Radar and Target LOS Distance Calculator is designed to determine
the Line Of Sight (LOS) distance between a radar (transmitter) and a
target (receiver). To comprehend its operation, one must understand the
following key concepts:

1.  Radar Height (*RH*): This parameter represents the height of the
    radar above the ground in meters (m). It is a crucial factor that
    affects LOS distance calculations.

2.  Target Height (*TH*): Similarly, the target height is specified in
    meters (m) and reflects the elevation of the target above the
    ground.

3.  \[*D*~1~, *D*~2~\] Calculation: The calculator calculates two
    intermediate distances, *D*~1~ and *D*~2~, using the radar and
    target heights, respectively. These distances are determined using
    the formula:

    ![](vertopal_98cff280a7734b4aa3555bc5938658f7/media/image1.wmf)
    (3.1)

> where the constants 4.12 and the square root operation are derived
> from geometric considerations.

4.  LOS Distance (*LOS Dist*): The LOS distance between the radar and
    target is the sum of *D*~1~ and *D*~2~, that is determined using the
    formula:

    ![](vertopal_98cff280a7734b4aa3555bc5938658f7/media/image2.wmf)
    (3.2)

> The final result is provided in both kilometers (km) and nautical
> miles (nm) for user convenience.

5.  Conversion to Nautical Miles: To provide an additional unit of
    measurement, the LOS distance is also converted to nautical miles
    (nm) by dividing the result by 1.85 (1 nautical mile is
    approximately 1.85 kilometers).

A systematic approach guided by mathematical principles and expert
insight is used to calculate radar and target LOS distance for the
mobile application.

## Receiver Sensitivity Analysis

1.  Signal-to-Noise Ratio (*SNR*): The development of the Receiver
    Sensitivity Analysis Calculator begins with an understanding of
    *SNR* and its significance in communication systems. *SNR* is a
    critical factor in determining receiver sensitivity.

2.  Noise Figure Analysis: Noise figure analysis is conducted to assess
    the impact of noise on receiver sensitivity. This involves
    understanding the role of noise figure (*NF*) and its calculation.

3.  Bandwidth (*BW*): Bandwidth is a key parameter affecting receiver
    sensitivity, and its relationship with noise is analyzed to
    determine the noise floor.

4.  Numerical Methods: Numerical techniques, including logarithmic
    calculations, are utilized to accurately calculate receiver
    sensitivity and noise floor.

To effectively utilize the Receiver Sensitivity Analysis Calculator, it
is essential to comprehend the following key concepts:

1.  Bandwidth (*BW*): *BW* represents the system\'s bandwidth in hertz
    (Hz), which determines the amount of information that can be
    transmitted or received.

2.  Noise Figure (*NF*): *NF*, measured in decibels (dB), quantifies the
    additional noise introduced by the receiver. A lower NF indicates
    better receiver performance.

3.  Noise Floor: The noise floor, expressed in decibels milliwatt (dBm),
    represents the minimum detectable signal power level in the presence
    of noise. The calculator computes the noise floor following the
    formula:

    ![](vertopal_98cff280a7734b4aa3555bc5938658f7/media/image3.wmf)
    (3.3)

> where the constant -174 represents the thermal noise floor.

4.  Sensitivity: Sensitivity, also in dBm, is the receiver's ability to
    detect weak signals while maintaining an acceptable *SNR*. The
    calculator calculates receiver sensitivity by adding the noise floor
    to *NF* value following the formula:

    ![](vertopal_98cff280a7734b4aa3555bc5938658f7/media/image4.wmf)
    (3.4)

This systematic approach, grounded in signal-to-noise ratio analysis and
precise mathematical calculations, ensures the accuracy and reliability
of the Receiver Sensitivity Analysis Calculator within the mobile
application.

c.  **Free Space Loss (FSL)**

```{=html}
<!-- -->
```
1.  Electromagnetic Theory: A deep understanding of electromagnetic
    theory was essential. We reviewed Maxwell\'s equations and
    electromagnetic wave propagation principles.

2.  Propagation Models: We explored various propagation models,
    including the Friis - transmission equation, to calculate free space
    loss.

3.  Numerical Methods: Numerical methods, such as integration
    techniques, were employed to handle complex calculations.

The Free Space Loss (FSL) calculator within our mobile application
operates based on the fundamental principles of signal propagation
through free space. It considers the following parameters:

1.  Transmitter Power (*P~Tx~*): This parameter represents the power of
    the transmitter in watts (W), signifying the signal source's
    strength. The calculator initially converts the transmitter power
    (*P~Tx~*) from watts (W) to decibels milliwatt (dBm) using the
    formula:

    ![](vertopal_98cff280a7734b4aa3555bc5938658f7/media/image5.wmf)
    (3.5)

2.  Transmitting Antenna Gain (*G~Tx~*): The gain of the transmitting
    antenna in decibels isotropic (dBi) reflects its effectiveness in
    directing the transmitted signal.

3.  Receiving Antenna Gain (*G~Rx~*): Similarly, the receiving
    antenna\'s gain in dBi indicates its ability to capture signals
    effectively.

4.  Frequency (*F*): The frequency of the signal, expressed in megahertz
    (MHz), plays a pivotal role in determining signal propagation
    characteristics.

5.  Distance (*R*): This parameter signifies the spatial separation
    between the transmitter and the receiver, measured in kilometers
    (km).

6.  Additional Loss (*L*): Users can account for any supplementary
    losses in the communication path, such as those caused by obstacles
    or interference, by specifying this value in decibels (dB).

7.  Receiver Sensitivity (*Sensitivity*): Receiver sensitivity, measured
    in decibels milliwatt (dBm), represents the minimum signal power
    required for successful detection.

The FSL calculator follows a systematic process to compute the Free
Space Loss:

1.  Received Power (*P~Rx~* (dBm)): The calculator calculates the
    received power at the receiver (*P~Rx~*) by considering transmitter
    power, antenna gains, frequency, distance, and additional losses.
    The formula for *P~Rx~* calculation is:

    ![](vertopal_98cff280a7734b4aa3555bc5938658f7/media/image6.wmf)
    (3.6)

2.  Signal-to-Noise Ratio (*SNR* (dB)): Finally, the Signal-to-Noise
    Ratio (*SNR*) is determined by subtracting the receiver sensitivity
    (*Sensitivity*) from the received power (*P~Rx~*), as follows:

    ![](vertopal_98cff280a7734b4aa3555bc5938658f7/media/image7.wmf)
    (3.7)

The resulting *SNR* value indicates the quality of the received signal
and is a critical factor in communication system performance. This
systematic approach, combined with rigorous research and consultations
with experts, underpins the accuracy and reliability of our FSL
calculator within the mobile application.

d.  **Maximum Detection Range Estimation**

```{=html}
<!-- -->
```
1.  Radar Fundamentals: The development of the Maximum Detection Range
    Estimation Calculator begins with a strong foundation in radar
    principles. This includes an understanding of radar power, antenna
    gains, radar cross-section (RCS), and radar sensitivity.

2.  Propagation Models: Propagation models, such as the radar range
    equation, are explored to estimate the maximum detection range.
    These models consider factors like signal propagation losses and
    pulse characteristics.

3.  Numerical Techniques: Numerical techniques, including logarithmic
    and exponential calculations, are applied to handle complex radar
    range estimations accurately.

To effectively utilize the Maximum Detection Range Estimation
Calculator, it is essential to comprehend the following key concepts:

1.  Transmitter Power (*P~Tx~*): *P~Tx~* represents the power of the
    radar transmitter in kilowatts (kW). It signifies the strength of
    the radar signal.

2.  Transmitting Antenna Gain (*G~Tx~*): Gt is the gain of the
    transmitting antenna in decibels isotropic (dBi). It indicates how
    effectively the radar antenna directs the signal.

3.  Receiving Antenna Gain (*G~Rx~*): Similarly, *G~Rx~* is the gain of
    the receiving antenna in dBi, reflecting its ability to capture
    radar signals.

4.  Radar Cross-Section (*RCS*): *RCS* is specified in decibels
    milliwatt per square meter (dBm^2^) and quantifies the reflective
    properties of the target.

5.  Number of Pulses: The number of radar pulses used in the detection
    process is a crucial parameter.

6.  Frequency (*F*): Freq represents the radar signal frequency in
    gigahertz (GHz), which influences signal propagation.

7.  Minimum Detectable Signal Power (MDS *P~Rx~*): MDS *P~Rx~*, measured
    in decibels milliwatt (dBm), is the minimum received power required
    for target detection.

8.  Additional Loss (*L*): Users can account for any supplementary
    losses, such as environmental factors or interference, by specifying
    this value in decibels (dB).

The Maximum Detection Range Estimation Calculator follows a systematic
calculation process:

1.  Transmitter Power Conversion (*P~Tx~* (dBm)): The calculator
    converts the radar transmitter power (*P~Tx~*) from kilowatts (kW)
    to decibels milliwatt (dBm) using the formula:

    ![](vertopal_98cff280a7734b4aa3555bc5938658f7/media/image8.wmf)
    (3.8)

> where 0.001 represents 1 milliwatt (mW) in dBm.

2.  40 log (*R*) Calculation: The calculator estimates the value of 40
    log (*R*), which is a key component in radar range estimation. This
    calculation considers Pt (dBm), antenna gains, *RCS*, the number of
    pulses, frequency, MDS *P~Rx~*, and additional losses:

    ![](vertopal_98cff280a7734b4aa3555bc5938658f7/media/image9.wmf)
    (3.9)

> where NOP is the number of pulses.

3.  Range (*R*) Calculation: Finally, the calculator computes the
    maximum detection range (*R*) by applying the inverse logarithmic
    operation to 40 log (*R*):

    ![](vertopal_98cff280a7734b4aa3555bc5938658f7/media/image10.wmf)
    (3.10)

This systematic approach, grounded in radar theory and precise
mathematical calculations, ensures the accuracy and reliability of the
Maximum Detection Range Estimation Calculator within the mobile
application.

#    RESULTS

## Analytical Proofs

The final program is provided on Google Play under the name (Radars &
Comms Calculator). The program calculates the LOS, receiver sensitivity,
losses, and maximum detection range following the formulas provided in
the Methodology chapter as shown in Figure 4-1.

![A screenshot of a phone Description automatically
generated](vertopal_98cff280a7734b4aa3555bc5938658f7/media/image11.png){width="1.9687839020122484in"
height="3.998672353455818in"}

**Figure ‎4‑1: Main menu of the Comms & Radar calculator.**

![](vertopal_98cff280a7734b4aa3555bc5938658f7/media/image12.png){width="1.6627930883639546in"
height="3.3771948818897637in"}![](vertopal_98cff280a7734b4aa3555bc5938658f7/media/image13.png){width="1.6877154418197726in"
height="3.427810586176728in"}![](vertopal_98cff280a7734b4aa3555bc5938658f7/media/image14.png){width="1.669371172353456in"
height="3.390553368328959in"}By selecting the function and apply the
parameters, the results are provided by the calculator as shown in
Figure 4-2.

#    CONCLUSION

## Conclusion

Our research methodology has resulted in a mobile application for radar
technology and communication systems that combines theory with practice.
In real-world scenarios, users can rely on our calculators for accurate
results. Our scientific approach, based upon mathematical principles and
expert insight, ensures accuracy.

Through the Google Play Store, you can download and install the mobile
application, which includes the four calculators described in this
report. We encourage users to explore its capabilities and leverage its
accuracy in radar and communication system calculations.

The complete source code of the mobile application can be found on our
GitHub repository for those interested in the underlying code and
technical details. The repository allows you to review the codebase,
contribute to its development, and gain a deeper understanding of the
algorithms and formulas employed in the calculators. Developers are
welcome to collaborate and engage in the project.

Researchers and enthusiasts in the rapidly evolving fields of radar
technology and communication systems will benefit from this research and
application. As a result of this innovative tool, we believe individuals
seeking precision, efficiency, and reliability in their calculations and
analyses will be able to benefit greatly.

[]{#_Toc145604405 .anchor}REFERENCES

\[1\] Hejlsberg, Anders, Scott Wiltamuth, and Peter Golde. C# language
specification. Addison-Wesley Longman Publishing Co., Inc., 2003.

\[2\] Kent, Brian M., et al. \"Dynamic radar cross section and radar
Doppler measurements of commercial General Electric windmill power
turbines Part 1: Predicted and measured radar signatures.\" IEEE
Antennas and Propagation Magazine 50.2 (2008): 211-219.

\[3\] Ulaby, Fawwaz T., Adnan Aslam, and Myron C. Dobson. \"Effects of
vegetation cover on the radar sensitivity to soil moisture.\" IEEE
Transactions on Geoscience and Remote Sensing 4 (1982): 476-481.

\[4\] Ghodgaonkar, Deepak K., Vasundara V. Varadan, and Vijay K.
Varadan. \"A free-space method for measurement of dielectric constants
and loss tangents at microwave frequencies.\" IEEE Transactions on
Instrumentation and measurement 38.3 (1989): 789-793.

\[5\] Barton, David K. \"Modern radar system analysis.\" Norwood (1988).

\[6\] Skolnik, Merrill Ivan. \"Introduction to radar systems.\" New York
(1980).
