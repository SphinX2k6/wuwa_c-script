using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ABF RID: 6847
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCharacterMaterialControllerCache")]
	[UnrealStructLayout(27040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 27040)]
	public class UKuroCharacterMaterialControllerCache : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019643 RID: 104003 RVA: 0x002584FE File Offset: 0x002566FE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCharacterMaterialControllerCache._ClassPtr;
		}

		// Token: 0x06019644 RID: 104004 RVA: 0x0025850C File Offset: 0x0025670C
		public UKuroCharacterMaterialControllerCache() : this(BuiltinUtils.AllocNativeUObject(UKuroCharacterMaterialControllerCache.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019645 RID: 104005 RVA: 0x00258534 File Offset: 0x00256734
		public UKuroCharacterMaterialControllerCache(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCharacterMaterialControllerCache.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006554 RID: 25940
		// (get) Token: 0x06019646 RID: 104006 RVA: 0x00258568 File Offset: 0x00256768
		// (set) Token: 0x06019647 RID: 104007 RVA: 0x002585A1 File Offset: 0x002567A1
		public FKuroCharMaterialControllerFloatGroup Rotation
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerFloatGroup result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new FKuroCharMaterialControllerFloatGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_Rotation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_Rotation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006555 RID: 25941
		// (get) Token: 0x06019648 RID: 104008 RVA: 0x002585C4 File Offset: 0x002567C4
		// (set) Token: 0x06019649 RID: 104009 RVA: 0x002585FD File Offset: 0x002567FD
		public FKuroCharMaterialControllerColorGroup TextureScaleAndOffset
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerColorGroup result;
				if ((result = this._TextureScaleAndOffset) == null)
				{
					result = (this._TextureScaleAndOffset = new FKuroCharMaterialControllerColorGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_TextureScaleAndOffset, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_TextureScaleAndOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006556 RID: 25942
		// (get) Token: 0x0601964A RID: 104010 RVA: 0x00258620 File Offset: 0x00256820
		// (set) Token: 0x0601964B RID: 104011 RVA: 0x00258659 File Offset: 0x00256859
		public FKuroCharMaterialControllerColorGroup TextureSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerColorGroup result;
				if ((result = this._TextureSpeed) == null)
				{
					result = (this._TextureSpeed = new FKuroCharMaterialControllerColorGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_TextureSpeed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_TextureSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006557 RID: 25943
		// (get) Token: 0x0601964C RID: 104012 RVA: 0x0025867C File Offset: 0x0025687C
		// (set) Token: 0x0601964D RID: 104013 RVA: 0x002586B5 File Offset: 0x002568B5
		public FKuroCharMaterialControllerColorGroup TextureColorTint
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerColorGroup result;
				if ((result = this._TextureColorTint) == null)
				{
					result = (this._TextureColorTint = new FKuroCharMaterialControllerColorGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_TextureColorTint, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_TextureColorTint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006558 RID: 25944
		// (get) Token: 0x0601964E RID: 104014 RVA: 0x002586D8 File Offset: 0x002568D8
		// (set) Token: 0x0601964F RID: 104015 RVA: 0x00258711 File Offset: 0x00256911
		public FKuroCharMaterialControllerFloatGroup TextureStrength
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerFloatGroup result;
				if ((result = this._TextureStrength) == null)
				{
					result = (this._TextureStrength = new FKuroCharMaterialControllerFloatGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_TextureStrength, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_TextureStrength, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006559 RID: 25945
		// (get) Token: 0x06019650 RID: 104016 RVA: 0x00258734 File Offset: 0x00256934
		// (set) Token: 0x06019651 RID: 104017 RVA: 0x0025876D File Offset: 0x0025696D
		public FKuroCharMaterialControllerFloatGroup TextureLowerLimit
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerFloatGroup result;
				if ((result = this._TextureLowerLimit) == null)
				{
					result = (this._TextureLowerLimit = new FKuroCharMaterialControllerFloatGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_TextureLowerLimit, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_TextureLowerLimit, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700655A RID: 25946
		// (get) Token: 0x06019652 RID: 104018 RVA: 0x00258790 File Offset: 0x00256990
		// (set) Token: 0x06019653 RID: 104019 RVA: 0x002587C9 File Offset: 0x002569C9
		public FKuroCharMaterialControllerFloatGroup TextureUpperLimit
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerFloatGroup result;
				if ((result = this._TextureUpperLimit) == null)
				{
					result = (this._TextureUpperLimit = new FKuroCharMaterialControllerFloatGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_TextureUpperLimit, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_TextureUpperLimit, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700655B RID: 25947
		// (get) Token: 0x06019654 RID: 104020 RVA: 0x002587EC File Offset: 0x002569EC
		// (set) Token: 0x06019655 RID: 104021 RVA: 0x00258825 File Offset: 0x00256A25
		public TArray<FKuroCharMaterialControllerFloatGroup> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCharMaterialControllerFloatGroup> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TArray<FKuroCharMaterialControllerFloatGroup>(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_FloatParameters, this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x1700655C RID: 25948
		// (get) Token: 0x06019656 RID: 104022 RVA: 0x00258834 File Offset: 0x00256A34
		// (set) Token: 0x06019657 RID: 104023 RVA: 0x0025886D File Offset: 0x00256A6D
		public TArray<FKuroCharMaterialControllerColorGroup> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCharMaterialControllerColorGroup> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TArray<FKuroCharMaterialControllerColorGroup>(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_ColorParameters, this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x1700655D RID: 25949
		// (get) Token: 0x06019658 RID: 104024 RVA: 0x0025887C File Offset: 0x00256A7C
		// (set) Token: 0x06019659 RID: 104025 RVA: 0x002588B5 File Offset: 0x00256AB5
		public FKuroCharMaterialControllerFloatGroup RimRange
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerFloatGroup result;
				if ((result = this._RimRange) == null)
				{
					result = (this._RimRange = new FKuroCharMaterialControllerFloatGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_RimRange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_RimRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700655E RID: 25950
		// (get) Token: 0x0601965A RID: 104026 RVA: 0x002588D8 File Offset: 0x00256AD8
		// (set) Token: 0x0601965B RID: 104027 RVA: 0x00258911 File Offset: 0x00256B11
		public FKuroCharMaterialControllerColorGroup RimColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerColorGroup result;
				if ((result = this._RimColor) == null)
				{
					result = (this._RimColor = new FKuroCharMaterialControllerColorGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_RimColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_RimColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700655F RID: 25951
		// (get) Token: 0x0601965C RID: 104028 RVA: 0x00258934 File Offset: 0x00256B34
		// (set) Token: 0x0601965D RID: 104029 RVA: 0x0025896D File Offset: 0x00256B6D
		public FKuroCharMaterialControllerFloatGroup OutlineWidth
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerFloatGroup result;
				if ((result = this._OutlineWidth) == null)
				{
					result = (this._OutlineWidth = new FKuroCharMaterialControllerFloatGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_OutlineWidth, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_OutlineWidth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006560 RID: 25952
		// (get) Token: 0x0601965E RID: 104030 RVA: 0x00258990 File Offset: 0x00256B90
		// (set) Token: 0x0601965F RID: 104031 RVA: 0x002589C9 File Offset: 0x00256BC9
		public FKuroCharMaterialControllerColorGroup OutlineColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerColorGroup result;
				if ((result = this._OutlineColor) == null)
				{
					result = (this._OutlineColor = new FKuroCharMaterialControllerColorGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_OutlineColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_OutlineColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006561 RID: 25953
		// (get) Token: 0x06019660 RID: 104032 RVA: 0x002589EC File Offset: 0x00256BEC
		// (set) Token: 0x06019661 RID: 104033 RVA: 0x00258A25 File Offset: 0x00256C25
		public FKuroCharMaterialControllerFloatGroup DissolveProgress
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerFloatGroup result;
				if ((result = this._DissolveProgress) == null)
				{
					result = (this._DissolveProgress = new FKuroCharMaterialControllerFloatGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_DissolveProgress, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_DissolveProgress, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006562 RID: 25954
		// (get) Token: 0x06019662 RID: 104034 RVA: 0x00258A48 File Offset: 0x00256C48
		// (set) Token: 0x06019663 RID: 104035 RVA: 0x00258A81 File Offset: 0x00256C81
		public FKuroCharMaterialControllerFloatGroup DissolveColorIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerFloatGroup result;
				if ((result = this._DissolveColorIntensity) == null)
				{
					result = (this._DissolveColorIntensity = new FKuroCharMaterialControllerFloatGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_DissolveColorIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_DissolveColorIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006563 RID: 25955
		// (get) Token: 0x06019664 RID: 104036 RVA: 0x00258AA4 File Offset: 0x00256CA4
		// (set) Token: 0x06019665 RID: 104037 RVA: 0x00258ADD File Offset: 0x00256CDD
		public FKuroCharMaterialControllerColorGroup DissolveColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerColorGroup result;
				if ((result = this._DissolveColor) == null)
				{
					result = (this._DissolveColor = new FKuroCharMaterialControllerColorGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_DissolveColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_DissolveColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006564 RID: 25956
		// (get) Token: 0x06019666 RID: 104038 RVA: 0x00258B00 File Offset: 0x00256D00
		// (set) Token: 0x06019667 RID: 104039 RVA: 0x00258B39 File Offset: 0x00256D39
		public FKuroCharMaterialControllerFloatGroup DissolveSmooth
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerFloatGroup result;
				if ((result = this._DissolveSmooth) == null)
				{
					result = (this._DissolveSmooth = new FKuroCharMaterialControllerFloatGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_DissolveSmooth, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_DissolveSmooth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006565 RID: 25957
		// (get) Token: 0x06019668 RID: 104040 RVA: 0x00258B5C File Offset: 0x00256D5C
		// (set) Token: 0x06019669 RID: 104041 RVA: 0x00258B95 File Offset: 0x00256D95
		public FKuroCharMaterialControllerColorGroup BaseColorTint
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerColorGroup result;
				if ((result = this._BaseColorTint) == null)
				{
					result = (this._BaseColorTint = new FKuroCharMaterialControllerColorGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_BaseColorTint, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_BaseColorTint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006566 RID: 25958
		// (get) Token: 0x0601966A RID: 104042 RVA: 0x00258BB8 File Offset: 0x00256DB8
		// (set) Token: 0x0601966B RID: 104043 RVA: 0x00258BF1 File Offset: 0x00256DF1
		public FKuroCharMaterialControllerColorGroup MainTexColorTint
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerColorGroup result;
				if ((result = this._MainTexColorTint) == null)
				{
					result = (this._MainTexColorTint = new FKuroCharMaterialControllerColorGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_MainTexColorTint, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_MainTexColorTint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006567 RID: 25959
		// (get) Token: 0x0601966C RID: 104044 RVA: 0x00258C14 File Offset: 0x00256E14
		// (set) Token: 0x0601966D RID: 104045 RVA: 0x00258C4D File Offset: 0x00256E4D
		public FKuroCharMaterialControllerColorGroup EmissionColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerColorGroup result;
				if ((result = this._EmissionColor) == null)
				{
					result = (this._EmissionColor = new FKuroCharMaterialControllerColorGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_EmissionColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_EmissionColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006568 RID: 25960
		// (get) Token: 0x0601966E RID: 104046 RVA: 0x00258C70 File Offset: 0x00256E70
		// (set) Token: 0x0601966F RID: 104047 RVA: 0x00258CA9 File Offset: 0x00256EA9
		public FKuroCharMaterialControllerFloatGroup EmissionIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerFloatGroup result;
				if ((result = this._EmissionIntensity) == null)
				{
					result = (this._EmissionIntensity = new FKuroCharMaterialControllerFloatGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_EmissionIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_EmissionIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006569 RID: 25961
		// (get) Token: 0x06019670 RID: 104048 RVA: 0x00258CCC File Offset: 0x00256ECC
		// (set) Token: 0x06019671 RID: 104049 RVA: 0x00258D05 File Offset: 0x00256F05
		public FKuroCharMaterialControllerColorGroup BaseRefine
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerColorGroup result;
				if ((result = this._BaseRefine) == null)
				{
					result = (this._BaseRefine = new FKuroCharMaterialControllerColorGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_BaseRefine, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_BaseRefine, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700656A RID: 25962
		// (get) Token: 0x06019672 RID: 104050 RVA: 0x00258D28 File Offset: 0x00256F28
		// (set) Token: 0x06019673 RID: 104051 RVA: 0x00258D61 File Offset: 0x00256F61
		public FKuroCharMaterialControllerColorGroup MotionColorStart
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerColorGroup result;
				if ((result = this._MotionColorStart) == null)
				{
					result = (this._MotionColorStart = new FKuroCharMaterialControllerColorGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_MotionColorStart, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_MotionColorStart, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700656B RID: 25963
		// (get) Token: 0x06019674 RID: 104052 RVA: 0x00258D84 File Offset: 0x00256F84
		// (set) Token: 0x06019675 RID: 104053 RVA: 0x00258DBD File Offset: 0x00256FBD
		public FKuroCharMaterialControllerColorGroup MotionColorEnd
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerColorGroup result;
				if ((result = this._MotionColorEnd) == null)
				{
					result = (this._MotionColorEnd = new FKuroCharMaterialControllerColorGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_MotionColorEnd, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_MotionColorEnd, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700656C RID: 25964
		// (get) Token: 0x06019676 RID: 104054 RVA: 0x00258DE0 File Offset: 0x00256FE0
		// (set) Token: 0x06019677 RID: 104055 RVA: 0x00258E19 File Offset: 0x00257019
		public FKuroCharMaterialControllerFloatGroup MotionNoiseSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerFloatGroup result;
				if ((result = this._MotionNoiseSpeed) == null)
				{
					result = (this._MotionNoiseSpeed = new FKuroCharMaterialControllerFloatGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_MotionNoiseSpeed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_MotionNoiseSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700656D RID: 25965
		// (get) Token: 0x06019678 RID: 104056 RVA: 0x00258E3C File Offset: 0x0025703C
		// (set) Token: 0x06019679 RID: 104057 RVA: 0x00258E75 File Offset: 0x00257075
		public FKuroCharMaterialControllerFloatGroup StripMaskProportion
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerFloatGroup result;
				if ((result = this._StripMaskProportion) == null)
				{
					result = (this._StripMaskProportion = new FKuroCharMaterialControllerFloatGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_StripMaskProportion, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_StripMaskProportion, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700656E RID: 25966
		// (get) Token: 0x0601967A RID: 104058 RVA: 0x00258E98 File Offset: 0x00257098
		// (set) Token: 0x0601967B RID: 104059 RVA: 0x00258ED1 File Offset: 0x002570D1
		public FKuroCharMaterialControllerFloatGroup StripMaskVScale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerFloatGroup result;
				if ((result = this._StripMaskVScale) == null)
				{
					result = (this._StripMaskVScale = new FKuroCharMaterialControllerFloatGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_StripMaskVScale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_StripMaskVScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700656F RID: 25967
		// (get) Token: 0x0601967C RID: 104060 RVA: 0x00258EF4 File Offset: 0x002570F4
		// (set) Token: 0x0601967D RID: 104061 RVA: 0x00258F2D File Offset: 0x0025712D
		public FKuroCharMaterialControllerFloatGroup StripMaskVSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerFloatGroup result;
				if ((result = this._StripMaskVSpeed) == null)
				{
					result = (this._StripMaskVSpeed = new FKuroCharMaterialControllerFloatGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_StripMaskVSpeed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_StripMaskVSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006570 RID: 25968
		// (get) Token: 0x0601967E RID: 104062 RVA: 0x00258F50 File Offset: 0x00257150
		// (set) Token: 0x0601967F RID: 104063 RVA: 0x00258F89 File Offset: 0x00257189
		public FKuroCharMaterialControllerFloatGroup DitherValue
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerFloatGroup result;
				if ((result = this._DitherValue) == null)
				{
					result = (this._DitherValue = new FKuroCharMaterialControllerFloatGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_DitherValue, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_DitherValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006571 RID: 25969
		// (get) Token: 0x06019680 RID: 104064 RVA: 0x00258FAC File Offset: 0x002571AC
		// (set) Token: 0x06019681 RID: 104065 RVA: 0x00258FE5 File Offset: 0x002571E5
		public TArray<FKuroCharMaterialControllerFloatGroup> CustomFloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCharMaterialControllerFloatGroup> result;
				if ((result = this._CustomFloatParameters) == null)
				{
					result = (this._CustomFloatParameters = new TArray<FKuroCharMaterialControllerFloatGroup>(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_CustomFloatParameters, this));
				}
				return result;
			}
			set
			{
				this.CustomFloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006572 RID: 25970
		// (get) Token: 0x06019682 RID: 104066 RVA: 0x00258FF4 File Offset: 0x002571F4
		// (set) Token: 0x06019683 RID: 104067 RVA: 0x0025902D File Offset: 0x0025722D
		public TArray<FKuroCharMaterialControllerColorGroup> CustomColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCharMaterialControllerColorGroup> result;
				if ((result = this._CustomColorParameters) == null)
				{
					result = (this._CustomColorParameters = new TArray<FKuroCharMaterialControllerColorGroup>(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_CustomColorParameters, this));
				}
				return result;
			}
			set
			{
				this.CustomColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006573 RID: 25971
		// (get) Token: 0x06019684 RID: 104068 RVA: 0x0025903C File Offset: 0x0025723C
		// (set) Token: 0x06019685 RID: 104069 RVA: 0x00259075 File Offset: 0x00257275
		public FKuroCharMaterialControllerFloatGroup HairDisplaceProgress
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerFloatGroup result;
				if ((result = this._HairDisplaceProgress) == null)
				{
					result = (this._HairDisplaceProgress = new FKuroCharMaterialControllerFloatGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_HairDisplaceProgress, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_HairDisplaceProgress, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006574 RID: 25972
		// (get) Token: 0x06019686 RID: 104070 RVA: 0x00259098 File Offset: 0x00257298
		// (set) Token: 0x06019687 RID: 104071 RVA: 0x002590D1 File Offset: 0x002572D1
		public FKuroCharMaterialControllerFloatGroup HairDisplaceContrast
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCharMaterialControllerFloatGroup result;
				if ((result = this._HairDisplaceContrast) == null)
				{
					result = (this._HairDisplaceContrast = new FKuroCharMaterialControllerFloatGroup(base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_HairDisplaceContrast, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCharMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroCharacterMaterialControllerCache.__PropertyOffset_HairDisplaceContrast, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06019688 RID: 104072 RVA: 0x002590F2 File Offset: 0x002572F2
		[NullableContext(2)]
		public void SetTextureUpperLimit(in FKuroCurveFloat Start, in FKuroCurveFloat Loop, in FKuroCurveFloat End)
		{
			UKuroCharacterMaterialControllerCache.__SetTextureUpperLimit_Internal(base.NativePtr, (Start ?? new FKuroCurveFloat()).NativePtr, (Loop ?? new FKuroCurveFloat()).NativePtr, (End ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x06019689 RID: 104073 RVA: 0x0025912F File Offset: 0x0025732F
		[NullableContext(2)]
		public void SetTextureStrength(in FKuroCurveFloat Start, in FKuroCurveFloat Loop, in FKuroCurveFloat End)
		{
			UKuroCharacterMaterialControllerCache.__SetTextureStrength_Internal(base.NativePtr, (Start ?? new FKuroCurveFloat()).NativePtr, (Loop ?? new FKuroCurveFloat()).NativePtr, (End ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x0601968A RID: 104074 RVA: 0x0025916C File Offset: 0x0025736C
		[NullableContext(2)]
		public void SetTextureSpeed(in FKuroCurveLinearColor Start, in FKuroCurveLinearColor Loop, in FKuroCurveLinearColor End)
		{
			UKuroCharacterMaterialControllerCache.__SetTextureSpeed_Internal(base.NativePtr, (Start ?? new FKuroCurveLinearColor()).NativePtr, (Loop ?? new FKuroCurveLinearColor()).NativePtr, (End ?? new FKuroCurveLinearColor()).NativePtr);
		}

		// Token: 0x0601968B RID: 104075 RVA: 0x002591A9 File Offset: 0x002573A9
		[NullableContext(2)]
		public void SetTextureScaleAndOffset(in FKuroCurveLinearColor Start, in FKuroCurveLinearColor Loop, in FKuroCurveLinearColor End)
		{
			UKuroCharacterMaterialControllerCache.__SetTextureScaleAndOffset_Internal(base.NativePtr, (Start ?? new FKuroCurveLinearColor()).NativePtr, (Loop ?? new FKuroCurveLinearColor()).NativePtr, (End ?? new FKuroCurveLinearColor()).NativePtr);
		}

		// Token: 0x0601968C RID: 104076 RVA: 0x002591E6 File Offset: 0x002573E6
		[NullableContext(2)]
		public void SetTextureLowerLimit(in FKuroCurveFloat Start, in FKuroCurveFloat Loop, in FKuroCurveFloat End)
		{
			UKuroCharacterMaterialControllerCache.__SetTextureLowerLimit_Internal(base.NativePtr, (Start ?? new FKuroCurveFloat()).NativePtr, (Loop ?? new FKuroCurveFloat()).NativePtr, (End ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x0601968D RID: 104077 RVA: 0x00259223 File Offset: 0x00257423
		[NullableContext(2)]
		public void SetTextureColorTint(in FKuroCurveLinearColor Start, in FKuroCurveLinearColor Loop, in FKuroCurveLinearColor End)
		{
			UKuroCharacterMaterialControllerCache.__SetTextureColorTint_Internal(base.NativePtr, (Start ?? new FKuroCurveLinearColor()).NativePtr, (Loop ?? new FKuroCurveLinearColor()).NativePtr, (End ?? new FKuroCurveLinearColor()).NativePtr);
		}

		// Token: 0x0601968E RID: 104078 RVA: 0x00259260 File Offset: 0x00257460
		[NullableContext(2)]
		public void SetStripMaskVSpeed(in FKuroCurveFloat Start, in FKuroCurveFloat Loop, in FKuroCurveFloat End)
		{
			UKuroCharacterMaterialControllerCache.__SetStripMaskVSpeed_Internal(base.NativePtr, (Start ?? new FKuroCurveFloat()).NativePtr, (Loop ?? new FKuroCurveFloat()).NativePtr, (End ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x0601968F RID: 104079 RVA: 0x0025929D File Offset: 0x0025749D
		[NullableContext(2)]
		public void SetStripMaskVScale(in FKuroCurveFloat Start, in FKuroCurveFloat Loop, in FKuroCurveFloat End)
		{
			UKuroCharacterMaterialControllerCache.__SetStripMaskVScale_Internal(base.NativePtr, (Start ?? new FKuroCurveFloat()).NativePtr, (Loop ?? new FKuroCurveFloat()).NativePtr, (End ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x06019690 RID: 104080 RVA: 0x002592DA File Offset: 0x002574DA
		[NullableContext(2)]
		public void SetStripMaskProportion(in FKuroCurveFloat Start, in FKuroCurveFloat Loop, in FKuroCurveFloat End)
		{
			UKuroCharacterMaterialControllerCache.__SetStripMaskProportion_Internal(base.NativePtr, (Start ?? new FKuroCurveFloat()).NativePtr, (Loop ?? new FKuroCurveFloat()).NativePtr, (End ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x06019691 RID: 104081 RVA: 0x00259317 File Offset: 0x00257517
		[NullableContext(2)]
		public void SetRotation(in FKuroCurveFloat Start, in FKuroCurveFloat Loop, in FKuroCurveFloat End)
		{
			UKuroCharacterMaterialControllerCache.__SetRotation_Internal(base.NativePtr, (Start ?? new FKuroCurveFloat()).NativePtr, (Loop ?? new FKuroCurveFloat()).NativePtr, (End ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x06019692 RID: 104082 RVA: 0x00259354 File Offset: 0x00257554
		[NullableContext(2)]
		public void SetRimRange(in FKuroCurveFloat Start, in FKuroCurveFloat Loop, in FKuroCurveFloat End)
		{
			UKuroCharacterMaterialControllerCache.__SetRimRange_Internal(base.NativePtr, (Start ?? new FKuroCurveFloat()).NativePtr, (Loop ?? new FKuroCurveFloat()).NativePtr, (End ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x06019693 RID: 104083 RVA: 0x00259391 File Offset: 0x00257591
		[NullableContext(2)]
		public void SetRimColor(in FKuroCurveLinearColor Start, in FKuroCurveLinearColor Loop, in FKuroCurveLinearColor End)
		{
			UKuroCharacterMaterialControllerCache.__SetRimColor_Internal(base.NativePtr, (Start ?? new FKuroCurveLinearColor()).NativePtr, (Loop ?? new FKuroCurveLinearColor()).NativePtr, (End ?? new FKuroCurveLinearColor()).NativePtr);
		}

		// Token: 0x06019694 RID: 104084 RVA: 0x002593CE File Offset: 0x002575CE
		[NullableContext(2)]
		public void SetOutlineWidth(in FKuroCurveFloat Start, in FKuroCurveFloat Loop, in FKuroCurveFloat End)
		{
			UKuroCharacterMaterialControllerCache.__SetOutlineWidth_Internal(base.NativePtr, (Start ?? new FKuroCurveFloat()).NativePtr, (Loop ?? new FKuroCurveFloat()).NativePtr, (End ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x06019695 RID: 104085 RVA: 0x0025940B File Offset: 0x0025760B
		[NullableContext(2)]
		public void SetOutlineColor(in FKuroCurveLinearColor Start, in FKuroCurveLinearColor Loop, in FKuroCurveLinearColor End)
		{
			UKuroCharacterMaterialControllerCache.__SetOutlineColor_Internal(base.NativePtr, (Start ?? new FKuroCurveLinearColor()).NativePtr, (Loop ?? new FKuroCurveLinearColor()).NativePtr, (End ?? new FKuroCurveLinearColor()).NativePtr);
		}

		// Token: 0x06019696 RID: 104086 RVA: 0x00259448 File Offset: 0x00257648
		[NullableContext(2)]
		public void SetMotionNoiseSpeed(in FKuroCurveFloat Start, in FKuroCurveFloat Loop, in FKuroCurveFloat End)
		{
			UKuroCharacterMaterialControllerCache.__SetMotionNoiseSpeed_Internal(base.NativePtr, (Start ?? new FKuroCurveFloat()).NativePtr, (Loop ?? new FKuroCurveFloat()).NativePtr, (End ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x06019697 RID: 104087 RVA: 0x00259485 File Offset: 0x00257685
		[NullableContext(2)]
		public void SetMotionColorStart(in FKuroCurveLinearColor Start, in FKuroCurveLinearColor Loop, in FKuroCurveLinearColor End)
		{
			UKuroCharacterMaterialControllerCache.__SetMotionColorStart_Internal(base.NativePtr, (Start ?? new FKuroCurveLinearColor()).NativePtr, (Loop ?? new FKuroCurveLinearColor()).NativePtr, (End ?? new FKuroCurveLinearColor()).NativePtr);
		}

		// Token: 0x06019698 RID: 104088 RVA: 0x002594C2 File Offset: 0x002576C2
		[NullableContext(2)]
		public void SetMotionColorEnd(in FKuroCurveLinearColor Start, in FKuroCurveLinearColor Loop, in FKuroCurveLinearColor End)
		{
			UKuroCharacterMaterialControllerCache.__SetMotionColorEnd_Internal(base.NativePtr, (Start ?? new FKuroCurveLinearColor()).NativePtr, (Loop ?? new FKuroCurveLinearColor()).NativePtr, (End ?? new FKuroCurveLinearColor()).NativePtr);
		}

		// Token: 0x06019699 RID: 104089 RVA: 0x002594FF File Offset: 0x002576FF
		[NullableContext(2)]
		public void SetMainTexColorTint(in FKuroCurveLinearColor Start, in FKuroCurveLinearColor Loop, in FKuroCurveLinearColor End)
		{
			UKuroCharacterMaterialControllerCache.__SetMainTexColorTint_Internal(base.NativePtr, (Start ?? new FKuroCurveLinearColor()).NativePtr, (Loop ?? new FKuroCurveLinearColor()).NativePtr, (End ?? new FKuroCurveLinearColor()).NativePtr);
		}

		// Token: 0x0601969A RID: 104090 RVA: 0x0025953C File Offset: 0x0025773C
		[NullableContext(2)]
		public void SetHairDisplaceProgress(in FKuroCurveFloat Start, in FKuroCurveFloat Loop, in FKuroCurveFloat End)
		{
			UKuroCharacterMaterialControllerCache.__SetHairDisplaceProgress_Internal(base.NativePtr, (Start ?? new FKuroCurveFloat()).NativePtr, (Loop ?? new FKuroCurveFloat()).NativePtr, (End ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x0601969B RID: 104091 RVA: 0x00259579 File Offset: 0x00257779
		[NullableContext(2)]
		public void SetHairDisplaceContrast(in FKuroCurveFloat Start, in FKuroCurveFloat Loop, in FKuroCurveFloat End)
		{
			UKuroCharacterMaterialControllerCache.__SetHairDisplaceContrast_Internal(base.NativePtr, (Start ?? new FKuroCurveFloat()).NativePtr, (Loop ?? new FKuroCurveFloat()).NativePtr, (End ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x0601969C RID: 104092 RVA: 0x002595B6 File Offset: 0x002577B6
		[NullableContext(2)]
		public void SetEmissionIntensity(in FKuroCurveFloat Start, in FKuroCurveFloat Loop, in FKuroCurveFloat End)
		{
			UKuroCharacterMaterialControllerCache.__SetEmissionIntensity_Internal(base.NativePtr, (Start ?? new FKuroCurveFloat()).NativePtr, (Loop ?? new FKuroCurveFloat()).NativePtr, (End ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x0601969D RID: 104093 RVA: 0x002595F3 File Offset: 0x002577F3
		[NullableContext(2)]
		public void SetEmissionColor(in FKuroCurveLinearColor Start, in FKuroCurveLinearColor Loop, in FKuroCurveLinearColor End)
		{
			UKuroCharacterMaterialControllerCache.__SetEmissionColor_Internal(base.NativePtr, (Start ?? new FKuroCurveLinearColor()).NativePtr, (Loop ?? new FKuroCurveLinearColor()).NativePtr, (End ?? new FKuroCurveLinearColor()).NativePtr);
		}

		// Token: 0x0601969E RID: 104094 RVA: 0x00259630 File Offset: 0x00257830
		[NullableContext(2)]
		public void SetDitherValue(in FKuroCurveFloat Start, in FKuroCurveFloat Loop, in FKuroCurveFloat End)
		{
			UKuroCharacterMaterialControllerCache.__SetDitherValue_Internal(base.NativePtr, (Start ?? new FKuroCurveFloat()).NativePtr, (Loop ?? new FKuroCurveFloat()).NativePtr, (End ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x0601969F RID: 104095 RVA: 0x0025966D File Offset: 0x0025786D
		[NullableContext(2)]
		public void SetDissolveSmooth(in FKuroCurveFloat Start, in FKuroCurveFloat Loop, in FKuroCurveFloat End)
		{
			UKuroCharacterMaterialControllerCache.__SetDissolveSmooth_Internal(base.NativePtr, (Start ?? new FKuroCurveFloat()).NativePtr, (Loop ?? new FKuroCurveFloat()).NativePtr, (End ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x060196A0 RID: 104096 RVA: 0x002596AA File Offset: 0x002578AA
		[NullableContext(2)]
		public void SetDissolveProgress(in FKuroCurveFloat Start, in FKuroCurveFloat Loop, in FKuroCurveFloat End)
		{
			UKuroCharacterMaterialControllerCache.__SetDissolveProgress_Internal(base.NativePtr, (Start ?? new FKuroCurveFloat()).NativePtr, (Loop ?? new FKuroCurveFloat()).NativePtr, (End ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x060196A1 RID: 104097 RVA: 0x002596E7 File Offset: 0x002578E7
		[NullableContext(2)]
		public void SetDissolveColorIntensity(in FKuroCurveFloat Start, in FKuroCurveFloat Loop, in FKuroCurveFloat End)
		{
			UKuroCharacterMaterialControllerCache.__SetDissolveColorIntensity_Internal(base.NativePtr, (Start ?? new FKuroCurveFloat()).NativePtr, (Loop ?? new FKuroCurveFloat()).NativePtr, (End ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x060196A2 RID: 104098 RVA: 0x00259724 File Offset: 0x00257924
		[NullableContext(2)]
		public void SetDissolveColor(in FKuroCurveLinearColor Start, in FKuroCurveLinearColor Loop, in FKuroCurveLinearColor End)
		{
			UKuroCharacterMaterialControllerCache.__SetDissolveColor_Internal(base.NativePtr, (Start ?? new FKuroCurveLinearColor()).NativePtr, (Loop ?? new FKuroCurveLinearColor()).NativePtr, (End ?? new FKuroCurveLinearColor()).NativePtr);
		}

		// Token: 0x060196A3 RID: 104099 RVA: 0x00259761 File Offset: 0x00257961
		public void SetCustomFloatParametersValue([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FKuroCurveFloat> Start, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<FKuroCurveFloat> Loop, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<FKuroCurveFloat> End)
		{
			UKuroCharacterMaterialControllerCache.__SetCustomFloatParametersValue_Internal(base.NativePtr, (Start ?? new TArray<FKuroCurveFloat>()).NativePtr, (Loop ?? new TArray<FKuroCurveFloat>()).NativePtr, (End ?? new TArray<FKuroCurveFloat>()).NativePtr);
		}

		// Token: 0x060196A4 RID: 104100 RVA: 0x0025979B File Offset: 0x0025799B
		public void SetCustomColorParametersValue([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FKuroCurveLinearColor> Start, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<FKuroCurveLinearColor> Loop, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<FKuroCurveLinearColor> End)
		{
			UKuroCharacterMaterialControllerCache.__SetCustomColorParametersValue_Internal(base.NativePtr, (Start ?? new TArray<FKuroCurveLinearColor>()).NativePtr, (Loop ?? new TArray<FKuroCurveLinearColor>()).NativePtr, (End ?? new TArray<FKuroCurveLinearColor>()).NativePtr);
		}

		// Token: 0x060196A5 RID: 104101 RVA: 0x002597D5 File Offset: 0x002579D5
		[NullableContext(2)]
		public void SetBaseRefine(in FKuroCurveLinearColor Start, in FKuroCurveLinearColor Loop, in FKuroCurveLinearColor End)
		{
			UKuroCharacterMaterialControllerCache.__SetBaseRefine_Internal(base.NativePtr, (Start ?? new FKuroCurveLinearColor()).NativePtr, (Loop ?? new FKuroCurveLinearColor()).NativePtr, (End ?? new FKuroCurveLinearColor()).NativePtr);
		}

		// Token: 0x060196A6 RID: 104102 RVA: 0x00259812 File Offset: 0x00257A12
		[NullableContext(2)]
		public void SetBaseColorTint(in FKuroCurveLinearColor Start, in FKuroCurveLinearColor Loop, in FKuroCurveLinearColor End)
		{
			UKuroCharacterMaterialControllerCache.__SetBaseColorTint_Internal(base.NativePtr, (Start ?? new FKuroCurveLinearColor()).NativePtr, (Loop ?? new FKuroCurveLinearColor()).NativePtr, (End ?? new FKuroCurveLinearColor()).NativePtr);
		}

		// Token: 0x060196A7 RID: 104103 RVA: 0x0025984F File Offset: 0x00257A4F
		public float GetTextureUpperLimit(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetTextureUpperLimit_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196A8 RID: 104104 RVA: 0x0025985E File Offset: 0x00257A5E
		public float GetTextureStrength(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetTextureStrength_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196A9 RID: 104105 RVA: 0x0025986D File Offset: 0x00257A6D
		public FLinearColor GetTextureSpeed(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetTextureSpeed_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196AA RID: 104106 RVA: 0x0025987C File Offset: 0x00257A7C
		public FLinearColor GetTextureScaleAndOffset(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetTextureScaleAndOffset_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196AB RID: 104107 RVA: 0x0025988B File Offset: 0x00257A8B
		public float GetTextureLowerLimit(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetTextureLowerLimit_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196AC RID: 104108 RVA: 0x0025989A File Offset: 0x00257A9A
		public FLinearColor GetTextureColorTint(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetTextureColorTint_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196AD RID: 104109 RVA: 0x002598A9 File Offset: 0x00257AA9
		public float GetStripMaskVSpeed(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetStripMaskVSpeed_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196AE RID: 104110 RVA: 0x002598B8 File Offset: 0x00257AB8
		public float GetStripMaskVScale(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetStripMaskVScale_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196AF RID: 104111 RVA: 0x002598C7 File Offset: 0x00257AC7
		public float GetStripMaskProportion(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetStripMaskProportion_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196B0 RID: 104112 RVA: 0x002598D6 File Offset: 0x00257AD6
		public float GetRotation(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetRotation_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196B1 RID: 104113 RVA: 0x002598E5 File Offset: 0x00257AE5
		public float GetRimRange(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetRimRange_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196B2 RID: 104114 RVA: 0x002598F4 File Offset: 0x00257AF4
		public FLinearColor GetRimColor(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetRimColor_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196B3 RID: 104115 RVA: 0x00259903 File Offset: 0x00257B03
		public float GetOutlineWidth(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetOutlineWidth_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196B4 RID: 104116 RVA: 0x00259912 File Offset: 0x00257B12
		public FLinearColor GetOutlineColor(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetOutlineColor_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196B5 RID: 104117 RVA: 0x00259921 File Offset: 0x00257B21
		public float GetMotionNoiseSpeed(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetMotionNoiseSpeed_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196B6 RID: 104118 RVA: 0x00259930 File Offset: 0x00257B30
		public FLinearColor GetMotionColorStart(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetMotionColorStart_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196B7 RID: 104119 RVA: 0x0025993F File Offset: 0x00257B3F
		public FLinearColor GetMotionColorEnd(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetMotionColorEnd_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196B8 RID: 104120 RVA: 0x0025994E File Offset: 0x00257B4E
		public FLinearColor GetMainTexColorTint(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetMainTexColorTint_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196B9 RID: 104121 RVA: 0x0025995D File Offset: 0x00257B5D
		public float GetHairDisplaceProgress(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetHairDisplaceProgress_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196BA RID: 104122 RVA: 0x0025996C File Offset: 0x00257B6C
		public float GetHairDisplaceContrast(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetHairDisplaceContrast_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196BB RID: 104123 RVA: 0x0025997B File Offset: 0x00257B7B
		public float GetEmissionIntensity(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetEmissionIntensity_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196BC RID: 104124 RVA: 0x0025998A File Offset: 0x00257B8A
		public FLinearColor GetEmissionColor(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetEmissionColor_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196BD RID: 104125 RVA: 0x00259999 File Offset: 0x00257B99
		public float GetDitherValue(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetDitherValue_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196BE RID: 104126 RVA: 0x002599A8 File Offset: 0x00257BA8
		public float GetDissolveSmooth(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetDissolveSmooth_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196BF RID: 104127 RVA: 0x002599B7 File Offset: 0x00257BB7
		public float GetDissolveProgress(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetDissolveProgress_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196C0 RID: 104128 RVA: 0x002599C6 File Offset: 0x00257BC6
		public float GetDissolveColorIntensity(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetDissolveColorIntensity_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196C1 RID: 104129 RVA: 0x002599D5 File Offset: 0x00257BD5
		public FLinearColor GetDissolveColor(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetDissolveColor_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196C2 RID: 104130 RVA: 0x002599E4 File Offset: 0x00257BE4
		public float GetCustomFloatParametersValue(float Factor, int Type, int Index)
		{
			return UKuroCharacterMaterialControllerCache.__GetCustomFloatParametersValue_Internal(base.NativePtr, Factor, Type, Index);
		}

		// Token: 0x060196C3 RID: 104131 RVA: 0x002599F4 File Offset: 0x00257BF4
		public FLinearColor GetCustomColorParametersValue(float Factor, int Type, int Index)
		{
			return UKuroCharacterMaterialControllerCache.__GetCustomColorParametersValue_Internal(base.NativePtr, Factor, Type, Index);
		}

		// Token: 0x060196C4 RID: 104132 RVA: 0x00259A04 File Offset: 0x00257C04
		public FLinearColor GetBaseRefine(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetBaseRefine_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196C5 RID: 104133 RVA: 0x00259A13 File Offset: 0x00257C13
		public FLinearColor GetBaseColorTint(float Factor, int Type)
		{
			return UKuroCharacterMaterialControllerCache.__GetBaseColorTint_Internal(base.NativePtr, Factor, Type);
		}

		// Token: 0x060196C6 RID: 104134
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextureUpperLimit_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196C7 RID: 104135
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextureStrength_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196C8 RID: 104136
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextureSpeed_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196C9 RID: 104137
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextureScaleAndOffset_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196CA RID: 104138
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextureLowerLimit_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196CB RID: 104139
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextureColorTint_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196CC RID: 104140
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStripMaskVSpeed_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196CD RID: 104141
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStripMaskVScale_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196CE RID: 104142
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStripMaskProportion_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196CF RID: 104143
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRotation_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196D0 RID: 104144
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRimRange_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196D1 RID: 104145
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRimColor_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196D2 RID: 104146
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOutlineWidth_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196D3 RID: 104147
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOutlineColor_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196D4 RID: 104148
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMotionNoiseSpeed_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196D5 RID: 104149
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMotionColorStart_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196D6 RID: 104150
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMotionColorEnd_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196D7 RID: 104151
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMainTexColorTint_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196D8 RID: 104152
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHairDisplaceProgress_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196D9 RID: 104153
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHairDisplaceContrast_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196DA RID: 104154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEmissionIntensity_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196DB RID: 104155
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEmissionColor_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196DC RID: 104156
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDitherValue_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196DD RID: 104157
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDissolveSmooth_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196DE RID: 104158
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDissolveProgress_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196DF RID: 104159
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDissolveColorIntensity_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196E0 RID: 104160
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDissolveColor_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196E1 RID: 104161
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomFloatParametersValue_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196E2 RID: 104162
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomColorParametersValue_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196E3 RID: 104163
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBaseRefine_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196E4 RID: 104164
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBaseColorTint_Internal(IntPtr @this, IntPtr Start, IntPtr Loop, IntPtr End);

		// Token: 0x060196E5 RID: 104165
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTextureUpperLimit_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196E6 RID: 104166
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTextureStrength_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196E7 RID: 104167
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetTextureSpeed_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196E8 RID: 104168
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetTextureScaleAndOffset_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196E9 RID: 104169
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTextureLowerLimit_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196EA RID: 104170
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetTextureColorTint_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196EB RID: 104171
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStripMaskVSpeed_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196EC RID: 104172
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStripMaskVScale_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196ED RID: 104173
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStripMaskProportion_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196EE RID: 104174
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRotation_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196EF RID: 104175
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRimRange_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196F0 RID: 104176
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetRimColor_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196F1 RID: 104177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetOutlineWidth_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196F2 RID: 104178
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetOutlineColor_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196F3 RID: 104179
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMotionNoiseSpeed_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196F4 RID: 104180
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetMotionColorStart_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196F5 RID: 104181
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetMotionColorEnd_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196F6 RID: 104182
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetMainTexColorTint_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196F7 RID: 104183
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetHairDisplaceProgress_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196F8 RID: 104184
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetHairDisplaceContrast_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196F9 RID: 104185
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetEmissionIntensity_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196FA RID: 104186
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetEmissionColor_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196FB RID: 104187
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDitherValue_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196FC RID: 104188
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDissolveSmooth_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196FD RID: 104189
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDissolveProgress_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196FE RID: 104190
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDissolveColorIntensity_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x060196FF RID: 104191
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetDissolveColor_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x06019700 RID: 104192
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCustomFloatParametersValue_Internal(IntPtr @this, float Factor, int Type, int Index);

		// Token: 0x06019701 RID: 104193
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetCustomColorParametersValue_Internal(IntPtr @this, float Factor, int Type, int Index);

		// Token: 0x06019702 RID: 104194
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetBaseRefine_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x06019703 RID: 104195
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetBaseColorTint_Internal(IntPtr @this, float Factor, int Type);

		// Token: 0x06019704 RID: 104196 RVA: 0x00259A22 File Offset: 0x00257C22
		static UKuroCharacterMaterialControllerCache()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroCharacterMaterialControllerCache");
		}

		// Token: 0x06019705 RID: 104197 RVA: 0x00259A30 File Offset: 0x00257C30
		protected UKuroCharacterMaterialControllerCache(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DD60 RID: 56672
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCharacterMaterialControllerCache";

		// Token: 0x0400DD61 RID: 56673
		private static IntPtr _ClassPtr;

		// Token: 0x0400DD62 RID: 56674
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DD63 RID: 56675
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400DD64 RID: 56676
		[Nullable(2)]
		private FKuroCharMaterialControllerFloatGroup _Rotation;

		// Token: 0x0400DD65 RID: 56677
		internal static int __PropertyOffset_TextureScaleAndOffset;

		// Token: 0x0400DD66 RID: 56678
		[Nullable(2)]
		private FKuroCharMaterialControllerColorGroup _TextureScaleAndOffset;

		// Token: 0x0400DD67 RID: 56679
		internal static int __PropertyOffset_TextureSpeed;

		// Token: 0x0400DD68 RID: 56680
		[Nullable(2)]
		private FKuroCharMaterialControllerColorGroup _TextureSpeed;

		// Token: 0x0400DD69 RID: 56681
		internal static int __PropertyOffset_TextureColorTint;

		// Token: 0x0400DD6A RID: 56682
		[Nullable(2)]
		private FKuroCharMaterialControllerColorGroup _TextureColorTint;

		// Token: 0x0400DD6B RID: 56683
		internal static int __PropertyOffset_TextureStrength;

		// Token: 0x0400DD6C RID: 56684
		[Nullable(2)]
		private FKuroCharMaterialControllerFloatGroup _TextureStrength;

		// Token: 0x0400DD6D RID: 56685
		internal static int __PropertyOffset_TextureLowerLimit;

		// Token: 0x0400DD6E RID: 56686
		[Nullable(2)]
		private FKuroCharMaterialControllerFloatGroup _TextureLowerLimit;

		// Token: 0x0400DD6F RID: 56687
		internal static int __PropertyOffset_TextureUpperLimit;

		// Token: 0x0400DD70 RID: 56688
		[Nullable(2)]
		private FKuroCharMaterialControllerFloatGroup _TextureUpperLimit;

		// Token: 0x0400DD71 RID: 56689
		internal static int __PropertyOffset_FloatParameters;

		// Token: 0x0400DD72 RID: 56690
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCharMaterialControllerFloatGroup> _FloatParameters;

		// Token: 0x0400DD73 RID: 56691
		internal static int __PropertyOffset_ColorParameters;

		// Token: 0x0400DD74 RID: 56692
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCharMaterialControllerColorGroup> _ColorParameters;

		// Token: 0x0400DD75 RID: 56693
		internal static int __PropertyOffset_RimRange;

		// Token: 0x0400DD76 RID: 56694
		[Nullable(2)]
		private FKuroCharMaterialControllerFloatGroup _RimRange;

		// Token: 0x0400DD77 RID: 56695
		internal static int __PropertyOffset_RimColor;

		// Token: 0x0400DD78 RID: 56696
		[Nullable(2)]
		private FKuroCharMaterialControllerColorGroup _RimColor;

		// Token: 0x0400DD79 RID: 56697
		internal static int __PropertyOffset_OutlineWidth;

		// Token: 0x0400DD7A RID: 56698
		[Nullable(2)]
		private FKuroCharMaterialControllerFloatGroup _OutlineWidth;

		// Token: 0x0400DD7B RID: 56699
		internal static int __PropertyOffset_OutlineColor;

		// Token: 0x0400DD7C RID: 56700
		[Nullable(2)]
		private FKuroCharMaterialControllerColorGroup _OutlineColor;

		// Token: 0x0400DD7D RID: 56701
		internal static int __PropertyOffset_DissolveProgress;

		// Token: 0x0400DD7E RID: 56702
		[Nullable(2)]
		private FKuroCharMaterialControllerFloatGroup _DissolveProgress;

		// Token: 0x0400DD7F RID: 56703
		internal static int __PropertyOffset_DissolveColorIntensity;

		// Token: 0x0400DD80 RID: 56704
		[Nullable(2)]
		private FKuroCharMaterialControllerFloatGroup _DissolveColorIntensity;

		// Token: 0x0400DD81 RID: 56705
		internal static int __PropertyOffset_DissolveColor;

		// Token: 0x0400DD82 RID: 56706
		[Nullable(2)]
		private FKuroCharMaterialControllerColorGroup _DissolveColor;

		// Token: 0x0400DD83 RID: 56707
		internal static int __PropertyOffset_DissolveSmooth;

		// Token: 0x0400DD84 RID: 56708
		[Nullable(2)]
		private FKuroCharMaterialControllerFloatGroup _DissolveSmooth;

		// Token: 0x0400DD85 RID: 56709
		internal static int __PropertyOffset_BaseColorTint;

		// Token: 0x0400DD86 RID: 56710
		[Nullable(2)]
		private FKuroCharMaterialControllerColorGroup _BaseColorTint;

		// Token: 0x0400DD87 RID: 56711
		internal static int __PropertyOffset_MainTexColorTint;

		// Token: 0x0400DD88 RID: 56712
		[Nullable(2)]
		private FKuroCharMaterialControllerColorGroup _MainTexColorTint;

		// Token: 0x0400DD89 RID: 56713
		internal static int __PropertyOffset_EmissionColor;

		// Token: 0x0400DD8A RID: 56714
		[Nullable(2)]
		private FKuroCharMaterialControllerColorGroup _EmissionColor;

		// Token: 0x0400DD8B RID: 56715
		internal static int __PropertyOffset_EmissionIntensity;

		// Token: 0x0400DD8C RID: 56716
		[Nullable(2)]
		private FKuroCharMaterialControllerFloatGroup _EmissionIntensity;

		// Token: 0x0400DD8D RID: 56717
		internal static int __PropertyOffset_BaseRefine;

		// Token: 0x0400DD8E RID: 56718
		[Nullable(2)]
		private FKuroCharMaterialControllerColorGroup _BaseRefine;

		// Token: 0x0400DD8F RID: 56719
		internal static int __PropertyOffset_MotionColorStart;

		// Token: 0x0400DD90 RID: 56720
		[Nullable(2)]
		private FKuroCharMaterialControllerColorGroup _MotionColorStart;

		// Token: 0x0400DD91 RID: 56721
		internal static int __PropertyOffset_MotionColorEnd;

		// Token: 0x0400DD92 RID: 56722
		[Nullable(2)]
		private FKuroCharMaterialControllerColorGroup _MotionColorEnd;

		// Token: 0x0400DD93 RID: 56723
		internal static int __PropertyOffset_MotionNoiseSpeed;

		// Token: 0x0400DD94 RID: 56724
		[Nullable(2)]
		private FKuroCharMaterialControllerFloatGroup _MotionNoiseSpeed;

		// Token: 0x0400DD95 RID: 56725
		internal static int __PropertyOffset_StripMaskProportion;

		// Token: 0x0400DD96 RID: 56726
		[Nullable(2)]
		private FKuroCharMaterialControllerFloatGroup _StripMaskProportion;

		// Token: 0x0400DD97 RID: 56727
		internal static int __PropertyOffset_StripMaskVScale;

		// Token: 0x0400DD98 RID: 56728
		[Nullable(2)]
		private FKuroCharMaterialControllerFloatGroup _StripMaskVScale;

		// Token: 0x0400DD99 RID: 56729
		internal static int __PropertyOffset_StripMaskVSpeed;

		// Token: 0x0400DD9A RID: 56730
		[Nullable(2)]
		private FKuroCharMaterialControllerFloatGroup _StripMaskVSpeed;

		// Token: 0x0400DD9B RID: 56731
		internal static int __PropertyOffset_DitherValue;

		// Token: 0x0400DD9C RID: 56732
		[Nullable(2)]
		private FKuroCharMaterialControllerFloatGroup _DitherValue;

		// Token: 0x0400DD9D RID: 56733
		internal static int __PropertyOffset_CustomFloatParameters;

		// Token: 0x0400DD9E RID: 56734
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCharMaterialControllerFloatGroup> _CustomFloatParameters;

		// Token: 0x0400DD9F RID: 56735
		internal static int __PropertyOffset_CustomColorParameters;

		// Token: 0x0400DDA0 RID: 56736
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCharMaterialControllerColorGroup> _CustomColorParameters;

		// Token: 0x0400DDA1 RID: 56737
		internal static int __PropertyOffset_HairDisplaceProgress;

		// Token: 0x0400DDA2 RID: 56738
		[Nullable(2)]
		private FKuroCharMaterialControllerFloatGroup _HairDisplaceProgress;

		// Token: 0x0400DDA3 RID: 56739
		internal static int __PropertyOffset_HairDisplaceContrast;

		// Token: 0x0400DDA4 RID: 56740
		[Nullable(2)]
		private FKuroCharMaterialControllerFloatGroup _HairDisplaceContrast;
	}
}
