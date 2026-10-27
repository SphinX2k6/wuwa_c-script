using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000AF0 RID: 2800
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Engine")]
	[UnrealStructLayout(7384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 7384)]
	public abstract class UEngine : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600905D RID: 36957 RVA: 0x000CE9D5 File Offset: 0x000CCBD5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEngine._ClassPtr;
		}

		// Token: 0x17002213 RID: 8723
		// (get) Token: 0x0600905E RID: 36958 RVA: 0x000CE9E1 File Offset: 0x000CCBE1
		// (set) Token: 0x0600905F RID: 36959 RVA: 0x000CE9F5 File Offset: 0x000CCBF5
		[Nullable(2)]
		public unsafe UFont TinyFont
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFont>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_TinyFont);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_TinyFont, value);
			}
		}

		// Token: 0x17002214 RID: 8724
		// (get) Token: 0x06009060 RID: 36960 RVA: 0x000CEA0C File Offset: 0x000CCC0C
		// (set) Token: 0x06009061 RID: 36961 RVA: 0x000CEA45 File Offset: 0x000CCC45
		public FSoftObjectPath TinyFontName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._TinyFontName) == null)
				{
					result = (this._TinyFontName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_TinyFontName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_TinyFontName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002215 RID: 8725
		// (get) Token: 0x06009062 RID: 36962 RVA: 0x000CEA66 File Offset: 0x000CCC66
		// (set) Token: 0x06009063 RID: 36963 RVA: 0x000CEA7A File Offset: 0x000CCC7A
		[Nullable(2)]
		public unsafe UFont SmallFont
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFont>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_SmallFont);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_SmallFont, value);
			}
		}

		// Token: 0x17002216 RID: 8726
		// (get) Token: 0x06009064 RID: 36964 RVA: 0x000CEA90 File Offset: 0x000CCC90
		// (set) Token: 0x06009065 RID: 36965 RVA: 0x000CEAC9 File Offset: 0x000CCCC9
		public FSoftObjectPath SmallFontName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._SmallFontName) == null)
				{
					result = (this._SmallFontName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_SmallFontName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_SmallFontName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002217 RID: 8727
		// (get) Token: 0x06009066 RID: 36966 RVA: 0x000CEAEA File Offset: 0x000CCCEA
		// (set) Token: 0x06009067 RID: 36967 RVA: 0x000CEAFE File Offset: 0x000CCCFE
		[Nullable(2)]
		public unsafe UFont MediumFont
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFont>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_MediumFont);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_MediumFont, value);
			}
		}

		// Token: 0x17002218 RID: 8728
		// (get) Token: 0x06009068 RID: 36968 RVA: 0x000CEB14 File Offset: 0x000CCD14
		// (set) Token: 0x06009069 RID: 36969 RVA: 0x000CEB4D File Offset: 0x000CCD4D
		public FSoftObjectPath MediumFontName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._MediumFontName) == null)
				{
					result = (this._MediumFontName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MediumFontName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MediumFontName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002219 RID: 8729
		// (get) Token: 0x0600906A RID: 36970 RVA: 0x000CEB6E File Offset: 0x000CCD6E
		// (set) Token: 0x0600906B RID: 36971 RVA: 0x000CEB82 File Offset: 0x000CCD82
		[Nullable(2)]
		public unsafe UFont LargeFont
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFont>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_LargeFont);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_LargeFont, value);
			}
		}

		// Token: 0x1700221A RID: 8730
		// (get) Token: 0x0600906C RID: 36972 RVA: 0x000CEB98 File Offset: 0x000CCD98
		// (set) Token: 0x0600906D RID: 36973 RVA: 0x000CEBD1 File Offset: 0x000CCDD1
		public FSoftObjectPath LargeFontName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._LargeFontName) == null)
				{
					result = (this._LargeFontName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_LargeFontName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_LargeFontName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700221B RID: 8731
		// (get) Token: 0x0600906E RID: 36974 RVA: 0x000CEBF2 File Offset: 0x000CCDF2
		// (set) Token: 0x0600906F RID: 36975 RVA: 0x000CEC06 File Offset: 0x000CCE06
		[Nullable(2)]
		public unsafe UFont SubtitleFont
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFont>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_SubtitleFont);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_SubtitleFont, value);
			}
		}

		// Token: 0x1700221C RID: 8732
		// (get) Token: 0x06009070 RID: 36976 RVA: 0x000CEC1C File Offset: 0x000CCE1C
		// (set) Token: 0x06009071 RID: 36977 RVA: 0x000CEC55 File Offset: 0x000CCE55
		public FSoftObjectPath SubtitleFontName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._SubtitleFontName) == null)
				{
					result = (this._SubtitleFontName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_SubtitleFontName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_SubtitleFontName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700221D RID: 8733
		// (get) Token: 0x06009072 RID: 36978 RVA: 0x000CEC78 File Offset: 0x000CCE78
		// (set) Token: 0x06009073 RID: 36979 RVA: 0x000CECB1 File Offset: 0x000CCEB1
		public TArray<UFont> AdditionalFonts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UFont> result;
				if ((result = this._AdditionalFonts) == null)
				{
					result = (this._AdditionalFonts = new TArray<UFont>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_AdditionalFonts, this));
				}
				return result;
			}
			set
			{
				this.AdditionalFonts.CopyAssign(value);
			}
		}

		// Token: 0x1700221E RID: 8734
		// (get) Token: 0x06009074 RID: 36980 RVA: 0x000CECC0 File Offset: 0x000CCEC0
		// (set) Token: 0x06009075 RID: 36981 RVA: 0x000CECF9 File Offset: 0x000CCEF9
		public TArray<string> AdditionalFontNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AdditionalFontNames) == null)
				{
					result = (this._AdditionalFontNames = new TArray<string>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_AdditionalFontNames, this));
				}
				return result;
			}
			set
			{
				this.AdditionalFontNames.CopyAssign(value);
			}
		}

		// Token: 0x1700221F RID: 8735
		// (get) Token: 0x06009076 RID: 36982 RVA: 0x000CED07 File Offset: 0x000CCF07
		// (set) Token: 0x06009077 RID: 36983 RVA: 0x000CED1B File Offset: 0x000CCF1B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UConsole> ConsoleClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_ConsoleClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_ConsoleClass) = value;
			}
		}

		// Token: 0x17002220 RID: 8736
		// (get) Token: 0x06009078 RID: 36984 RVA: 0x000CED30 File Offset: 0x000CCF30
		// (set) Token: 0x06009079 RID: 36985 RVA: 0x000CED69 File Offset: 0x000CCF69
		public FSoftClassPath ConsoleClassName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._ConsoleClassName) == null)
				{
					result = (this._ConsoleClassName = new FSoftClassPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_ConsoleClassName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_ConsoleClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002221 RID: 8737
		// (get) Token: 0x0600907A RID: 36986 RVA: 0x000CED8A File Offset: 0x000CCF8A
		// (set) Token: 0x0600907B RID: 36987 RVA: 0x000CED9E File Offset: 0x000CCF9E
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UGameViewportClient> GameViewportClientClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_GameViewportClientClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_GameViewportClientClass) = value;
			}
		}

		// Token: 0x17002222 RID: 8738
		// (get) Token: 0x0600907C RID: 36988 RVA: 0x000CEDB4 File Offset: 0x000CCFB4
		// (set) Token: 0x0600907D RID: 36989 RVA: 0x000CEDED File Offset: 0x000CCFED
		public FSoftClassPath GameViewportClientClassName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._GameViewportClientClassName) == null)
				{
					result = (this._GameViewportClientClassName = new FSoftClassPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_GameViewportClientClassName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_GameViewportClientClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002223 RID: 8739
		// (get) Token: 0x0600907E RID: 36990 RVA: 0x000CEE0E File Offset: 0x000CD00E
		// (set) Token: 0x0600907F RID: 36991 RVA: 0x000CEE22 File Offset: 0x000CD022
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<ULocalPlayer> LocalPlayerClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_LocalPlayerClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_LocalPlayerClass) = value;
			}
		}

		// Token: 0x17002224 RID: 8740
		// (get) Token: 0x06009080 RID: 36992 RVA: 0x000CEE38 File Offset: 0x000CD038
		// (set) Token: 0x06009081 RID: 36993 RVA: 0x000CEE71 File Offset: 0x000CD071
		public FSoftClassPath LocalPlayerClassName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._LocalPlayerClassName) == null)
				{
					result = (this._LocalPlayerClassName = new FSoftClassPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_LocalPlayerClassName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_LocalPlayerClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002225 RID: 8741
		// (get) Token: 0x06009082 RID: 36994 RVA: 0x000CEE92 File Offset: 0x000CD092
		// (set) Token: 0x06009083 RID: 36995 RVA: 0x000CEEA6 File Offset: 0x000CD0A6
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AWorldSettings> WorldSettingsClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_WorldSettingsClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_WorldSettingsClass) = value;
			}
		}

		// Token: 0x17002226 RID: 8742
		// (get) Token: 0x06009084 RID: 36996 RVA: 0x000CEEBC File Offset: 0x000CD0BC
		// (set) Token: 0x06009085 RID: 36997 RVA: 0x000CEEF5 File Offset: 0x000CD0F5
		public FSoftClassPath WorldSettingsClassName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._WorldSettingsClassName) == null)
				{
					result = (this._WorldSettingsClassName = new FSoftClassPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_WorldSettingsClassName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_WorldSettingsClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002227 RID: 8743
		// (get) Token: 0x06009086 RID: 36998 RVA: 0x000CEF18 File Offset: 0x000CD118
		// (set) Token: 0x06009087 RID: 36999 RVA: 0x000CEF51 File Offset: 0x000CD151
		public FSoftClassPath NavigationSystemClassName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._NavigationSystemClassName) == null)
				{
					result = (this._NavigationSystemClassName = new FSoftClassPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_NavigationSystemClassName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_NavigationSystemClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002228 RID: 8744
		// (get) Token: 0x06009088 RID: 37000 RVA: 0x000CEF72 File Offset: 0x000CD172
		// (set) Token: 0x06009089 RID: 37001 RVA: 0x000CEF86 File Offset: 0x000CD186
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavigationSystemBase> NavigationSystemClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_NavigationSystemClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_NavigationSystemClass) = value;
			}
		}

		// Token: 0x17002229 RID: 8745
		// (get) Token: 0x0600908A RID: 37002 RVA: 0x000CEF9C File Offset: 0x000CD19C
		// (set) Token: 0x0600908B RID: 37003 RVA: 0x000CEFD5 File Offset: 0x000CD1D5
		public FSoftClassPath NavigationSystemConfigClassName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._NavigationSystemConfigClassName) == null)
				{
					result = (this._NavigationSystemConfigClassName = new FSoftClassPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_NavigationSystemConfigClassName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_NavigationSystemConfigClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700222A RID: 8746
		// (get) Token: 0x0600908C RID: 37004 RVA: 0x000CEFF6 File Offset: 0x000CD1F6
		// (set) Token: 0x0600908D RID: 37005 RVA: 0x000CF00A File Offset: 0x000CD20A
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavigationSystemConfig> NavigationSystemConfigClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_NavigationSystemConfigClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_NavigationSystemConfigClass) = value;
			}
		}

		// Token: 0x1700222B RID: 8747
		// (get) Token: 0x0600908E RID: 37006 RVA: 0x000CF020 File Offset: 0x000CD220
		// (set) Token: 0x0600908F RID: 37007 RVA: 0x000CF059 File Offset: 0x000CD259
		public FSoftClassPath AvoidanceManagerClassName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._AvoidanceManagerClassName) == null)
				{
					result = (this._AvoidanceManagerClassName = new FSoftClassPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_AvoidanceManagerClassName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_AvoidanceManagerClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700222C RID: 8748
		// (get) Token: 0x06009090 RID: 37008 RVA: 0x000CF07A File Offset: 0x000CD27A
		// (set) Token: 0x06009091 RID: 37009 RVA: 0x000CF08E File Offset: 0x000CD28E
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UAvoidanceManager> AvoidanceManagerClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_AvoidanceManagerClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_AvoidanceManagerClass) = value;
			}
		}

		// Token: 0x1700222D RID: 8749
		// (get) Token: 0x06009092 RID: 37010 RVA: 0x000CF0A4 File Offset: 0x000CD2A4
		// (set) Token: 0x06009093 RID: 37011 RVA: 0x000CF0DD File Offset: 0x000CD2DD
		public FSoftClassPath AIControllerClassName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._AIControllerClassName) == null)
				{
					result = (this._AIControllerClassName = new FSoftClassPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_AIControllerClassName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_AIControllerClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700222E RID: 8750
		// (get) Token: 0x06009094 RID: 37012 RVA: 0x000CF0FE File Offset: 0x000CD2FE
		// (set) Token: 0x06009095 RID: 37013 RVA: 0x000CF112 File Offset: 0x000CD312
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UPhysicsCollisionHandler> PhysicsCollisionHandlerClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_PhysicsCollisionHandlerClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_PhysicsCollisionHandlerClass) = value;
			}
		}

		// Token: 0x1700222F RID: 8751
		// (get) Token: 0x06009096 RID: 37014 RVA: 0x000CF128 File Offset: 0x000CD328
		// (set) Token: 0x06009097 RID: 37015 RVA: 0x000CF161 File Offset: 0x000CD361
		public FSoftClassPath PhysicsCollisionHandlerClassName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._PhysicsCollisionHandlerClassName) == null)
				{
					result = (this._PhysicsCollisionHandlerClassName = new FSoftClassPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_PhysicsCollisionHandlerClassName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_PhysicsCollisionHandlerClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002230 RID: 8752
		// (get) Token: 0x06009098 RID: 37016 RVA: 0x000CF184 File Offset: 0x000CD384
		// (set) Token: 0x06009099 RID: 37017 RVA: 0x000CF1BD File Offset: 0x000CD3BD
		public FSoftClassPath GameUserSettingsClassName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._GameUserSettingsClassName) == null)
				{
					result = (this._GameUserSettingsClassName = new FSoftClassPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_GameUserSettingsClassName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_GameUserSettingsClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002231 RID: 8753
		// (get) Token: 0x0600909A RID: 37018 RVA: 0x000CF1DE File Offset: 0x000CD3DE
		// (set) Token: 0x0600909B RID: 37019 RVA: 0x000CF1F2 File Offset: 0x000CD3F2
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UGameUserSettings> GameUserSettingsClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_GameUserSettingsClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_GameUserSettingsClass) = value;
			}
		}

		// Token: 0x17002232 RID: 8754
		// (get) Token: 0x0600909C RID: 37020 RVA: 0x000CF207 File Offset: 0x000CD407
		// (set) Token: 0x0600909D RID: 37021 RVA: 0x000CF21B File Offset: 0x000CD41B
		[Nullable(2)]
		public unsafe UGameUserSettings GameUserSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameUserSettings>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_GameUserSettings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_GameUserSettings, value);
			}
		}

		// Token: 0x17002233 RID: 8755
		// (get) Token: 0x0600909E RID: 37022 RVA: 0x000CF230 File Offset: 0x000CD430
		// (set) Token: 0x0600909F RID: 37023 RVA: 0x000CF244 File Offset: 0x000CD444
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<ALevelScriptActor> LevelScriptActorClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_LevelScriptActorClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_LevelScriptActorClass) = value;
			}
		}

		// Token: 0x17002234 RID: 8756
		// (get) Token: 0x060090A0 RID: 37024 RVA: 0x000CF25C File Offset: 0x000CD45C
		// (set) Token: 0x060090A1 RID: 37025 RVA: 0x000CF295 File Offset: 0x000CD495
		public FSoftClassPath LevelScriptActorClassName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._LevelScriptActorClassName) == null)
				{
					result = (this._LevelScriptActorClassName = new FSoftClassPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_LevelScriptActorClassName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_LevelScriptActorClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002235 RID: 8757
		// (get) Token: 0x060090A2 RID: 37026 RVA: 0x000CF2B8 File Offset: 0x000CD4B8
		// (set) Token: 0x060090A3 RID: 37027 RVA: 0x000CF2F1 File Offset: 0x000CD4F1
		public FSoftClassPath DefaultBlueprintBaseClassName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._DefaultBlueprintBaseClassName) == null)
				{
					result = (this._DefaultBlueprintBaseClassName = new FSoftClassPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DefaultBlueprintBaseClassName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DefaultBlueprintBaseClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002236 RID: 8758
		// (get) Token: 0x060090A4 RID: 37028 RVA: 0x000CF314 File Offset: 0x000CD514
		// (set) Token: 0x060090A5 RID: 37029 RVA: 0x000CF34D File Offset: 0x000CD54D
		public FSoftClassPath GameSingletonClassName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._GameSingletonClassName) == null)
				{
					result = (this._GameSingletonClassName = new FSoftClassPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_GameSingletonClassName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_GameSingletonClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002237 RID: 8759
		// (get) Token: 0x060090A6 RID: 37030 RVA: 0x000CF36E File Offset: 0x000CD56E
		// (set) Token: 0x060090A7 RID: 37031 RVA: 0x000CF382 File Offset: 0x000CD582
		[Nullable(2)]
		public unsafe UObject GameSingleton
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_GameSingleton);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_GameSingleton, value);
			}
		}

		// Token: 0x17002238 RID: 8760
		// (get) Token: 0x060090A8 RID: 37032 RVA: 0x000CF398 File Offset: 0x000CD598
		// (set) Token: 0x060090A9 RID: 37033 RVA: 0x000CF3D1 File Offset: 0x000CD5D1
		public FSoftClassPath AssetManagerClassName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._AssetManagerClassName) == null)
				{
					result = (this._AssetManagerClassName = new FSoftClassPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_AssetManagerClassName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_AssetManagerClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002239 RID: 8761
		// (get) Token: 0x060090AA RID: 37034 RVA: 0x000CF3F2 File Offset: 0x000CD5F2
		// (set) Token: 0x060090AB RID: 37035 RVA: 0x000CF406 File Offset: 0x000CD606
		[Nullable(2)]
		public unsafe UAssetManager AssetManager
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAssetManager>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_AssetManager);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_AssetManager, value);
			}
		}

		// Token: 0x1700223A RID: 8762
		// (get) Token: 0x060090AC RID: 37036 RVA: 0x000CF41B File Offset: 0x000CD61B
		// (set) Token: 0x060090AD RID: 37037 RVA: 0x000CF42F File Offset: 0x000CD62F
		[Nullable(2)]
		public unsafe UTexture2D DefaultTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_DefaultTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_DefaultTexture, value);
			}
		}

		// Token: 0x1700223B RID: 8763
		// (get) Token: 0x060090AE RID: 37038 RVA: 0x000CF444 File Offset: 0x000CD644
		// (set) Token: 0x060090AF RID: 37039 RVA: 0x000CF47D File Offset: 0x000CD67D
		public FSoftObjectPath DefaultTextureName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._DefaultTextureName) == null)
				{
					result = (this._DefaultTextureName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DefaultTextureName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DefaultTextureName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700223C RID: 8764
		// (get) Token: 0x060090B0 RID: 37040 RVA: 0x000CF49E File Offset: 0x000CD69E
		// (set) Token: 0x060090B1 RID: 37041 RVA: 0x000CF4B2 File Offset: 0x000CD6B2
		[Nullable(2)]
		public unsafe UTexture DefaultDiffuseTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_DefaultDiffuseTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_DefaultDiffuseTexture, value);
			}
		}

		// Token: 0x1700223D RID: 8765
		// (get) Token: 0x060090B2 RID: 37042 RVA: 0x000CF4C8 File Offset: 0x000CD6C8
		// (set) Token: 0x060090B3 RID: 37043 RVA: 0x000CF501 File Offset: 0x000CD701
		public FSoftObjectPath DefaultDiffuseTextureName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._DefaultDiffuseTextureName) == null)
				{
					result = (this._DefaultDiffuseTextureName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DefaultDiffuseTextureName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DefaultDiffuseTextureName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700223E RID: 8766
		// (get) Token: 0x060090B4 RID: 37044 RVA: 0x000CF522 File Offset: 0x000CD722
		// (set) Token: 0x060090B5 RID: 37045 RVA: 0x000CF536 File Offset: 0x000CD736
		[Nullable(2)]
		public unsafe UTexture2D DefaultBSPVertexTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_DefaultBSPVertexTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_DefaultBSPVertexTexture, value);
			}
		}

		// Token: 0x1700223F RID: 8767
		// (get) Token: 0x060090B6 RID: 37046 RVA: 0x000CF54C File Offset: 0x000CD74C
		// (set) Token: 0x060090B7 RID: 37047 RVA: 0x000CF585 File Offset: 0x000CD785
		public FSoftObjectPath DefaultBSPVertexTextureName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._DefaultBSPVertexTextureName) == null)
				{
					result = (this._DefaultBSPVertexTextureName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DefaultBSPVertexTextureName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DefaultBSPVertexTextureName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002240 RID: 8768
		// (get) Token: 0x060090B8 RID: 37048 RVA: 0x000CF5A6 File Offset: 0x000CD7A6
		// (set) Token: 0x060090B9 RID: 37049 RVA: 0x000CF5BA File Offset: 0x000CD7BA
		[Nullable(2)]
		public unsafe UTexture2D HighFrequencyNoiseTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_HighFrequencyNoiseTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_HighFrequencyNoiseTexture, value);
			}
		}

		// Token: 0x17002241 RID: 8769
		// (get) Token: 0x060090BA RID: 37050 RVA: 0x000CF5D0 File Offset: 0x000CD7D0
		// (set) Token: 0x060090BB RID: 37051 RVA: 0x000CF609 File Offset: 0x000CD809
		public FSoftObjectPath HighFrequencyNoiseTextureName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._HighFrequencyNoiseTextureName) == null)
				{
					result = (this._HighFrequencyNoiseTextureName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_HighFrequencyNoiseTextureName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_HighFrequencyNoiseTextureName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002242 RID: 8770
		// (get) Token: 0x060090BC RID: 37052 RVA: 0x000CF62A File Offset: 0x000CD82A
		// (set) Token: 0x060090BD RID: 37053 RVA: 0x000CF63E File Offset: 0x000CD83E
		[Nullable(2)]
		public unsafe UTexture2D DefaultBokehTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_DefaultBokehTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_DefaultBokehTexture, value);
			}
		}

		// Token: 0x17002243 RID: 8771
		// (get) Token: 0x060090BE RID: 37054 RVA: 0x000CF654 File Offset: 0x000CD854
		// (set) Token: 0x060090BF RID: 37055 RVA: 0x000CF68D File Offset: 0x000CD88D
		public FSoftObjectPath DefaultBokehTextureName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._DefaultBokehTextureName) == null)
				{
					result = (this._DefaultBokehTextureName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DefaultBokehTextureName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DefaultBokehTextureName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002244 RID: 8772
		// (get) Token: 0x060090C0 RID: 37056 RVA: 0x000CF6AE File Offset: 0x000CD8AE
		// (set) Token: 0x060090C1 RID: 37057 RVA: 0x000CF6C2 File Offset: 0x000CD8C2
		[Nullable(2)]
		public unsafe UTexture2D DefaultBloomKernelTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_DefaultBloomKernelTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_DefaultBloomKernelTexture, value);
			}
		}

		// Token: 0x17002245 RID: 8773
		// (get) Token: 0x060090C2 RID: 37058 RVA: 0x000CF6D8 File Offset: 0x000CD8D8
		// (set) Token: 0x060090C3 RID: 37059 RVA: 0x000CF711 File Offset: 0x000CD911
		public FSoftObjectPath DefaultBloomKernelTextureName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._DefaultBloomKernelTextureName) == null)
				{
					result = (this._DefaultBloomKernelTextureName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DefaultBloomKernelTextureName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DefaultBloomKernelTextureName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002246 RID: 8774
		// (get) Token: 0x060090C4 RID: 37060 RVA: 0x000CF732 File Offset: 0x000CD932
		// (set) Token: 0x060090C5 RID: 37061 RVA: 0x000CF746 File Offset: 0x000CD946
		[Nullable(2)]
		public unsafe UMaterial WireframeMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_WireframeMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_WireframeMaterial, value);
			}
		}

		// Token: 0x17002247 RID: 8775
		// (get) Token: 0x060090C6 RID: 37062 RVA: 0x000CF75B File Offset: 0x000CD95B
		// (set) Token: 0x060090C7 RID: 37063 RVA: 0x000CF76F File Offset: 0x000CD96F
		public unsafe string WireframeMaterialName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_WireframeMaterialName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_WireframeMaterialName)), value);
			}
		}

		// Token: 0x17002248 RID: 8776
		// (get) Token: 0x060090C8 RID: 37064 RVA: 0x000CF784 File Offset: 0x000CD984
		// (set) Token: 0x060090C9 RID: 37065 RVA: 0x000CF798 File Offset: 0x000CD998
		[Nullable(2)]
		public unsafe UMaterial VisGeoNormalMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_VisGeoNormalMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_VisGeoNormalMaterial, value);
			}
		}

		// Token: 0x17002249 RID: 8777
		// (get) Token: 0x060090CA RID: 37066 RVA: 0x000CF7AD File Offset: 0x000CD9AD
		// (set) Token: 0x060090CB RID: 37067 RVA: 0x000CF7C1 File Offset: 0x000CD9C1
		public unsafe string VisGeoNormalMaterialName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_VisGeoNormalMaterialName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_VisGeoNormalMaterialName)), value);
			}
		}

		// Token: 0x1700224A RID: 8778
		// (get) Token: 0x060090CC RID: 37068 RVA: 0x000CF7D6 File Offset: 0x000CD9D6
		// (set) Token: 0x060090CD RID: 37069 RVA: 0x000CF7EA File Offset: 0x000CD9EA
		[Nullable(2)]
		public unsafe UMaterial DebugMeshMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_DebugMeshMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_DebugMeshMaterial, value);
			}
		}

		// Token: 0x1700224B RID: 8779
		// (get) Token: 0x060090CE RID: 37070 RVA: 0x000CF800 File Offset: 0x000CDA00
		// (set) Token: 0x060090CF RID: 37071 RVA: 0x000CF839 File Offset: 0x000CDA39
		public FSoftObjectPath DebugMeshMaterialName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._DebugMeshMaterialName) == null)
				{
					result = (this._DebugMeshMaterialName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DebugMeshMaterialName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DebugMeshMaterialName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700224C RID: 8780
		// (get) Token: 0x060090D0 RID: 37072 RVA: 0x000CF85A File Offset: 0x000CDA5A
		// (set) Token: 0x060090D1 RID: 37073 RVA: 0x000CF86E File Offset: 0x000CDA6E
		[Nullable(2)]
		public unsafe UMaterial DebugCanCharacterStandUpOnMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_DebugCanCharacterStandUpOnMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_DebugCanCharacterStandUpOnMaterial, value);
			}
		}

		// Token: 0x1700224D RID: 8781
		// (get) Token: 0x060090D2 RID: 37074 RVA: 0x000CF884 File Offset: 0x000CDA84
		// (set) Token: 0x060090D3 RID: 37075 RVA: 0x000CF8BD File Offset: 0x000CDABD
		public FSoftObjectPath DebugCanCharacterStandUpOnName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._DebugCanCharacterStandUpOnName) == null)
				{
					result = (this._DebugCanCharacterStandUpOnName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DebugCanCharacterStandUpOnName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DebugCanCharacterStandUpOnName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700224E RID: 8782
		// (get) Token: 0x060090D4 RID: 37076 RVA: 0x000CF8DE File Offset: 0x000CDADE
		// (set) Token: 0x060090D5 RID: 37077 RVA: 0x000CF8F2 File Offset: 0x000CDAF2
		[Nullable(2)]
		public unsafe UMaterial EmissiveMeshMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_EmissiveMeshMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_EmissiveMeshMaterial, value);
			}
		}

		// Token: 0x1700224F RID: 8783
		// (get) Token: 0x060090D6 RID: 37078 RVA: 0x000CF908 File Offset: 0x000CDB08
		// (set) Token: 0x060090D7 RID: 37079 RVA: 0x000CF941 File Offset: 0x000CDB41
		public FSoftObjectPath EmissiveMeshMaterialName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._EmissiveMeshMaterialName) == null)
				{
					result = (this._EmissiveMeshMaterialName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_EmissiveMeshMaterialName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_EmissiveMeshMaterialName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002250 RID: 8784
		// (get) Token: 0x060090D8 RID: 37080 RVA: 0x000CF962 File Offset: 0x000CDB62
		// (set) Token: 0x060090D9 RID: 37081 RVA: 0x000CF976 File Offset: 0x000CDB76
		[Nullable(2)]
		public unsafe UMaterial LevelColorationLitMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_LevelColorationLitMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_LevelColorationLitMaterial, value);
			}
		}

		// Token: 0x17002251 RID: 8785
		// (get) Token: 0x060090DA RID: 37082 RVA: 0x000CF98B File Offset: 0x000CDB8B
		// (set) Token: 0x060090DB RID: 37083 RVA: 0x000CF99F File Offset: 0x000CDB9F
		public unsafe string LevelColorationLitMaterialName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_LevelColorationLitMaterialName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_LevelColorationLitMaterialName)), value);
			}
		}

		// Token: 0x17002252 RID: 8786
		// (get) Token: 0x060090DC RID: 37084 RVA: 0x000CF9B4 File Offset: 0x000CDBB4
		// (set) Token: 0x060090DD RID: 37085 RVA: 0x000CF9C8 File Offset: 0x000CDBC8
		[Nullable(2)]
		public unsafe UMaterial LevelColorationUnlitMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_LevelColorationUnlitMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_LevelColorationUnlitMaterial, value);
			}
		}

		// Token: 0x17002253 RID: 8787
		// (get) Token: 0x060090DE RID: 37086 RVA: 0x000CF9DD File Offset: 0x000CDBDD
		// (set) Token: 0x060090DF RID: 37087 RVA: 0x000CF9F1 File Offset: 0x000CDBF1
		public unsafe string LevelColorationUnlitMaterialName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_LevelColorationUnlitMaterialName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_LevelColorationUnlitMaterialName)), value);
			}
		}

		// Token: 0x17002254 RID: 8788
		// (get) Token: 0x060090E0 RID: 37088 RVA: 0x000CFA06 File Offset: 0x000CDC06
		// (set) Token: 0x060090E1 RID: 37089 RVA: 0x000CFA1A File Offset: 0x000CDC1A
		[Nullable(2)]
		public unsafe UMaterial LightingTexelDensityMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_LightingTexelDensityMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_LightingTexelDensityMaterial, value);
			}
		}

		// Token: 0x17002255 RID: 8789
		// (get) Token: 0x060090E2 RID: 37090 RVA: 0x000CFA2F File Offset: 0x000CDC2F
		// (set) Token: 0x060090E3 RID: 37091 RVA: 0x000CFA43 File Offset: 0x000CDC43
		public unsafe string LightingTexelDensityName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_LightingTexelDensityName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_LightingTexelDensityName)), value);
			}
		}

		// Token: 0x17002256 RID: 8790
		// (get) Token: 0x060090E4 RID: 37092 RVA: 0x000CFA58 File Offset: 0x000CDC58
		// (set) Token: 0x060090E5 RID: 37093 RVA: 0x000CFA6C File Offset: 0x000CDC6C
		[Nullable(2)]
		public unsafe UMaterial ShadedLevelColorationLitMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ShadedLevelColorationLitMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ShadedLevelColorationLitMaterial, value);
			}
		}

		// Token: 0x17002257 RID: 8791
		// (get) Token: 0x060090E6 RID: 37094 RVA: 0x000CFA81 File Offset: 0x000CDC81
		// (set) Token: 0x060090E7 RID: 37095 RVA: 0x000CFA95 File Offset: 0x000CDC95
		public unsafe string ShadedLevelColorationLitMaterialName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_ShadedLevelColorationLitMaterialName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_ShadedLevelColorationLitMaterialName)), value);
			}
		}

		// Token: 0x17002258 RID: 8792
		// (get) Token: 0x060090E8 RID: 37096 RVA: 0x000CFAAA File Offset: 0x000CDCAA
		// (set) Token: 0x060090E9 RID: 37097 RVA: 0x000CFABE File Offset: 0x000CDCBE
		[Nullable(2)]
		public unsafe UMaterial ShadedLevelColorationUnlitMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ShadedLevelColorationUnlitMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ShadedLevelColorationUnlitMaterial, value);
			}
		}

		// Token: 0x17002259 RID: 8793
		// (get) Token: 0x060090EA RID: 37098 RVA: 0x000CFAD3 File Offset: 0x000CDCD3
		// (set) Token: 0x060090EB RID: 37099 RVA: 0x000CFAE7 File Offset: 0x000CDCE7
		public unsafe string ShadedLevelColorationUnlitMaterialName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_ShadedLevelColorationUnlitMaterialName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_ShadedLevelColorationUnlitMaterialName)), value);
			}
		}

		// Token: 0x1700225A RID: 8794
		// (get) Token: 0x060090EC RID: 37100 RVA: 0x000CFAFC File Offset: 0x000CDCFC
		// (set) Token: 0x060090ED RID: 37101 RVA: 0x000CFB35 File Offset: 0x000CDD35
		public TMap<string, UMaterial> Generate2DMapParentMaterialMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, UMaterial> result;
				if ((result = this._Generate2DMapParentMaterialMap) == null)
				{
					result = (this._Generate2DMapParentMaterialMap = new TMap<string, UMaterial>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_Generate2DMapParentMaterialMap, this));
				}
				return result;
			}
			set
			{
				this.Generate2DMapParentMaterialMap.CopyAssign(value);
			}
		}

		// Token: 0x1700225B RID: 8795
		// (get) Token: 0x060090EE RID: 37102 RVA: 0x000CFB44 File Offset: 0x000CDD44
		// (set) Token: 0x060090EF RID: 37103 RVA: 0x000CFB7D File Offset: 0x000CDD7D
		public TMap<string, UMaterial> Generate2DMapNameTagMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, UMaterial> result;
				if ((result = this._Generate2DMapNameTagMap) == null)
				{
					result = (this._Generate2DMapNameTagMap = new TMap<string, UMaterial>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_Generate2DMapNameTagMap, this));
				}
				return result;
			}
			set
			{
				this.Generate2DMapNameTagMap.CopyAssign(value);
			}
		}

		// Token: 0x1700225C RID: 8796
		// (get) Token: 0x060090F0 RID: 37104 RVA: 0x000CFB8C File Offset: 0x000CDD8C
		// (set) Token: 0x060090F1 RID: 37105 RVA: 0x000CFBC5 File Offset: 0x000CDDC5
		public TMap<string, UMaterial> Generate2DMapMeshPathMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, UMaterial> result;
				if ((result = this._Generate2DMapMeshPathMap) == null)
				{
					result = (this._Generate2DMapMeshPathMap = new TMap<string, UMaterial>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_Generate2DMapMeshPathMap, this));
				}
				return result;
			}
			set
			{
				this.Generate2DMapMeshPathMap.CopyAssign(value);
			}
		}

		// Token: 0x1700225D RID: 8797
		// (get) Token: 0x060090F2 RID: 37106 RVA: 0x000CFBD4 File Offset: 0x000CDDD4
		// (set) Token: 0x060090F3 RID: 37107 RVA: 0x000CFC0D File Offset: 0x000CDE0D
		public FKuro2DMapGenerateMatMap Kuro2DMapGenerateMatMapJson
		{
			get
			{
				base.FastCheckIsValid();
				FKuro2DMapGenerateMatMap result;
				if ((result = this._Kuro2DMapGenerateMatMapJson) == null)
				{
					result = (this._Kuro2DMapGenerateMatMapJson = new FKuro2DMapGenerateMatMap(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_Kuro2DMapGenerateMatMapJson, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuro2DMapGenerateMatMap.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_Kuro2DMapGenerateMatMapJson, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700225E RID: 8798
		// (get) Token: 0x060090F4 RID: 37108 RVA: 0x000CFC2E File Offset: 0x000CDE2E
		// (set) Token: 0x060090F5 RID: 37109 RVA: 0x000CFC42 File Offset: 0x000CDE42
		[Nullable(2)]
		public unsafe UMaterial Generate2DMapLandMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_Generate2DMapLandMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_Generate2DMapLandMaterial, value);
			}
		}

		// Token: 0x1700225F RID: 8799
		// (get) Token: 0x060090F6 RID: 37110 RVA: 0x000CFC57 File Offset: 0x000CDE57
		// (set) Token: 0x060090F7 RID: 37111 RVA: 0x000CFC6B File Offset: 0x000CDE6B
		public unsafe string Generate2DMapLandMaterialName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_Generate2DMapLandMaterialName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_Generate2DMapLandMaterialName)), value);
			}
		}

		// Token: 0x17002260 RID: 8800
		// (get) Token: 0x060090F8 RID: 37112 RVA: 0x000CFC80 File Offset: 0x000CDE80
		// (set) Token: 0x060090F9 RID: 37113 RVA: 0x000CFC94 File Offset: 0x000CDE94
		[Nullable(2)]
		public unsafe UMaterial Generate2DMapBuildingMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_Generate2DMapBuildingMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_Generate2DMapBuildingMaterial, value);
			}
		}

		// Token: 0x17002261 RID: 8801
		// (get) Token: 0x060090FA RID: 37114 RVA: 0x000CFCA9 File Offset: 0x000CDEA9
		// (set) Token: 0x060090FB RID: 37115 RVA: 0x000CFCBD File Offset: 0x000CDEBD
		public unsafe string Generate2DMapBuildingMaterialName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_Generate2DMapBuildingMaterialName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_Generate2DMapBuildingMaterialName)), value);
			}
		}

		// Token: 0x17002262 RID: 8802
		// (get) Token: 0x060090FC RID: 37116 RVA: 0x000CFCD2 File Offset: 0x000CDED2
		// (set) Token: 0x060090FD RID: 37117 RVA: 0x000CFCE6 File Offset: 0x000CDEE6
		[Nullable(2)]
		public unsafe UMaterial Generate2DMapWaterMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_Generate2DMapWaterMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_Generate2DMapWaterMaterial, value);
			}
		}

		// Token: 0x17002263 RID: 8803
		// (get) Token: 0x060090FE RID: 37118 RVA: 0x000CFCFB File Offset: 0x000CDEFB
		// (set) Token: 0x060090FF RID: 37119 RVA: 0x000CFD0F File Offset: 0x000CDF0F
		public unsafe string Generate2DMapWaterMaterialName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_Generate2DMapWaterMaterialName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_Generate2DMapWaterMaterialName)), value);
			}
		}

		// Token: 0x17002264 RID: 8804
		// (get) Token: 0x06009100 RID: 37120 RVA: 0x000CFD24 File Offset: 0x000CDF24
		// (set) Token: 0x06009101 RID: 37121 RVA: 0x000CFD38 File Offset: 0x000CDF38
		[Nullable(2)]
		public unsafe UMaterial Generate2DMapTreeMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_Generate2DMapTreeMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_Generate2DMapTreeMaterial, value);
			}
		}

		// Token: 0x17002265 RID: 8805
		// (get) Token: 0x06009102 RID: 37122 RVA: 0x000CFD4D File Offset: 0x000CDF4D
		// (set) Token: 0x06009103 RID: 37123 RVA: 0x000CFD61 File Offset: 0x000CDF61
		public unsafe string Generate2DMapTreeMaterialName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_Generate2DMapTreeMaterialName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_Generate2DMapTreeMaterialName)), value);
			}
		}

		// Token: 0x17002266 RID: 8806
		// (get) Token: 0x06009104 RID: 37124 RVA: 0x000CFD76 File Offset: 0x000CDF76
		// (set) Token: 0x06009105 RID: 37125 RVA: 0x000CFD8A File Offset: 0x000CDF8A
		[Nullable(2)]
		public unsafe UMaterial Generate2DMapNoneMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_Generate2DMapNoneMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_Generate2DMapNoneMaterial, value);
			}
		}

		// Token: 0x17002267 RID: 8807
		// (get) Token: 0x06009106 RID: 37126 RVA: 0x000CFD9F File Offset: 0x000CDF9F
		// (set) Token: 0x06009107 RID: 37127 RVA: 0x000CFDB3 File Offset: 0x000CDFB3
		public unsafe string Generate2DMapNoneMaterialName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_Generate2DMapNoneMaterialName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_Generate2DMapNoneMaterialName)), value);
			}
		}

		// Token: 0x17002268 RID: 8808
		// (get) Token: 0x06009108 RID: 37128 RVA: 0x000CFDC8 File Offset: 0x000CDFC8
		// (set) Token: 0x06009109 RID: 37129 RVA: 0x000CFDDC File Offset: 0x000CDFDC
		[Nullable(2)]
		public unsafe UMaterial Generate2DMapSpecil01Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_Generate2DMapSpecil01Material);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_Generate2DMapSpecil01Material, value);
			}
		}

		// Token: 0x17002269 RID: 8809
		// (get) Token: 0x0600910A RID: 37130 RVA: 0x000CFDF1 File Offset: 0x000CDFF1
		// (set) Token: 0x0600910B RID: 37131 RVA: 0x000CFE05 File Offset: 0x000CE005
		public unsafe string Generate2DMapSpecil01MaterialName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_Generate2DMapSpecil01MaterialName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_Generate2DMapSpecil01MaterialName)), value);
			}
		}

		// Token: 0x1700226A RID: 8810
		// (get) Token: 0x0600910C RID: 37132 RVA: 0x000CFE1A File Offset: 0x000CE01A
		// (set) Token: 0x0600910D RID: 37133 RVA: 0x000CFE2E File Offset: 0x000CE02E
		[Nullable(2)]
		public unsafe UMaterial Generate2DMapSpecil02Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_Generate2DMapSpecil02Material);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_Generate2DMapSpecil02Material, value);
			}
		}

		// Token: 0x1700226B RID: 8811
		// (get) Token: 0x0600910E RID: 37134 RVA: 0x000CFE43 File Offset: 0x000CE043
		// (set) Token: 0x0600910F RID: 37135 RVA: 0x000CFE57 File Offset: 0x000CE057
		public unsafe string Generate2DMapSpecil02MaterialName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_Generate2DMapSpecil02MaterialName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_Generate2DMapSpecil02MaterialName)), value);
			}
		}

		// Token: 0x1700226C RID: 8812
		// (get) Token: 0x06009110 RID: 37136 RVA: 0x000CFE6C File Offset: 0x000CE06C
		// (set) Token: 0x06009111 RID: 37137 RVA: 0x000CFE80 File Offset: 0x000CE080
		[Nullable(2)]
		public unsafe UMaterial PSODebugFallbackMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_PSODebugFallbackMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_PSODebugFallbackMaterial, value);
			}
		}

		// Token: 0x1700226D RID: 8813
		// (get) Token: 0x06009112 RID: 37138 RVA: 0x000CFE98 File Offset: 0x000CE098
		// (set) Token: 0x06009113 RID: 37139 RVA: 0x000CFED1 File Offset: 0x000CE0D1
		public FSoftObjectPath PSODebugFallbackMaterialName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._PSODebugFallbackMaterialName) == null)
				{
					result = (this._PSODebugFallbackMaterialName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_PSODebugFallbackMaterialName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_PSODebugFallbackMaterialName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700226E RID: 8814
		// (get) Token: 0x06009114 RID: 37140 RVA: 0x000CFEF2 File Offset: 0x000CE0F2
		// (set) Token: 0x06009115 RID: 37141 RVA: 0x000CFF06 File Offset: 0x000CE106
		[Nullable(2)]
		public unsafe UMaterial RemoveSurfaceMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_RemoveSurfaceMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_RemoveSurfaceMaterial, value);
			}
		}

		// Token: 0x1700226F RID: 8815
		// (get) Token: 0x06009116 RID: 37142 RVA: 0x000CFF1C File Offset: 0x000CE11C
		// (set) Token: 0x06009117 RID: 37143 RVA: 0x000CFF55 File Offset: 0x000CE155
		public FSoftObjectPath RemoveSurfaceMaterialName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._RemoveSurfaceMaterialName) == null)
				{
					result = (this._RemoveSurfaceMaterialName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_RemoveSurfaceMaterialName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_RemoveSurfaceMaterialName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002270 RID: 8816
		// (get) Token: 0x06009118 RID: 37144 RVA: 0x000CFF76 File Offset: 0x000CE176
		// (set) Token: 0x06009119 RID: 37145 RVA: 0x000CFF8A File Offset: 0x000CE18A
		[Nullable(2)]
		public unsafe UMaterial VertexColorMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_VertexColorMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_VertexColorMaterial, value);
			}
		}

		// Token: 0x17002271 RID: 8817
		// (get) Token: 0x0600911A RID: 37146 RVA: 0x000CFF9F File Offset: 0x000CE19F
		// (set) Token: 0x0600911B RID: 37147 RVA: 0x000CFFB3 File Offset: 0x000CE1B3
		public unsafe string VertexColorMaterialName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_VertexColorMaterialName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_VertexColorMaterialName)), value);
			}
		}

		// Token: 0x17002272 RID: 8818
		// (get) Token: 0x0600911C RID: 37148 RVA: 0x000CFFC8 File Offset: 0x000CE1C8
		// (set) Token: 0x0600911D RID: 37149 RVA: 0x000CFFDC File Offset: 0x000CE1DC
		[Nullable(2)]
		public unsafe UMaterial VertexColorViewModeMaterial_ColorOnly
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_VertexColorViewModeMaterial_ColorOnly);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_VertexColorViewModeMaterial_ColorOnly, value);
			}
		}

		// Token: 0x17002273 RID: 8819
		// (get) Token: 0x0600911E RID: 37150 RVA: 0x000CFFF1 File Offset: 0x000CE1F1
		// (set) Token: 0x0600911F RID: 37151 RVA: 0x000D0005 File Offset: 0x000CE205
		public unsafe string VertexColorViewModeMaterialName_ColorOnly
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_VertexColorViewModeMaterialName_ColorOnly)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_VertexColorViewModeMaterialName_ColorOnly)), value);
			}
		}

		// Token: 0x17002274 RID: 8820
		// (get) Token: 0x06009120 RID: 37152 RVA: 0x000D001A File Offset: 0x000CE21A
		// (set) Token: 0x06009121 RID: 37153 RVA: 0x000D002E File Offset: 0x000CE22E
		[Nullable(2)]
		public unsafe UMaterial VertexColorViewModeMaterial_AlphaAsColor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_VertexColorViewModeMaterial_AlphaAsColor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_VertexColorViewModeMaterial_AlphaAsColor, value);
			}
		}

		// Token: 0x17002275 RID: 8821
		// (get) Token: 0x06009122 RID: 37154 RVA: 0x000D0043 File Offset: 0x000CE243
		// (set) Token: 0x06009123 RID: 37155 RVA: 0x000D0057 File Offset: 0x000CE257
		public unsafe string VertexColorViewModeMaterialName_AlphaAsColor
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_VertexColorViewModeMaterialName_AlphaAsColor)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_VertexColorViewModeMaterialName_AlphaAsColor)), value);
			}
		}

		// Token: 0x17002276 RID: 8822
		// (get) Token: 0x06009124 RID: 37156 RVA: 0x000D006C File Offset: 0x000CE26C
		// (set) Token: 0x06009125 RID: 37157 RVA: 0x000D0080 File Offset: 0x000CE280
		[Nullable(2)]
		public unsafe UMaterial VertexColorViewModeMaterial_RedOnly
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_VertexColorViewModeMaterial_RedOnly);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_VertexColorViewModeMaterial_RedOnly, value);
			}
		}

		// Token: 0x17002277 RID: 8823
		// (get) Token: 0x06009126 RID: 37158 RVA: 0x000D0095 File Offset: 0x000CE295
		// (set) Token: 0x06009127 RID: 37159 RVA: 0x000D00A9 File Offset: 0x000CE2A9
		public unsafe string VertexColorViewModeMaterialName_RedOnly
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_VertexColorViewModeMaterialName_RedOnly)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_VertexColorViewModeMaterialName_RedOnly)), value);
			}
		}

		// Token: 0x17002278 RID: 8824
		// (get) Token: 0x06009128 RID: 37160 RVA: 0x000D00BE File Offset: 0x000CE2BE
		// (set) Token: 0x06009129 RID: 37161 RVA: 0x000D00D2 File Offset: 0x000CE2D2
		[Nullable(2)]
		public unsafe UMaterial VertexColorViewModeMaterial_GreenOnly
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_VertexColorViewModeMaterial_GreenOnly);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_VertexColorViewModeMaterial_GreenOnly, value);
			}
		}

		// Token: 0x17002279 RID: 8825
		// (get) Token: 0x0600912A RID: 37162 RVA: 0x000D00E7 File Offset: 0x000CE2E7
		// (set) Token: 0x0600912B RID: 37163 RVA: 0x000D00FB File Offset: 0x000CE2FB
		public unsafe string VertexColorViewModeMaterialName_GreenOnly
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_VertexColorViewModeMaterialName_GreenOnly)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_VertexColorViewModeMaterialName_GreenOnly)), value);
			}
		}

		// Token: 0x1700227A RID: 8826
		// (get) Token: 0x0600912C RID: 37164 RVA: 0x000D0110 File Offset: 0x000CE310
		// (set) Token: 0x0600912D RID: 37165 RVA: 0x000D0124 File Offset: 0x000CE324
		[Nullable(2)]
		public unsafe UMaterial VertexColorViewModeMaterial_BlueOnly
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_VertexColorViewModeMaterial_BlueOnly);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_VertexColorViewModeMaterial_BlueOnly, value);
			}
		}

		// Token: 0x1700227B RID: 8827
		// (get) Token: 0x0600912E RID: 37166 RVA: 0x000D0139 File Offset: 0x000CE339
		// (set) Token: 0x0600912F RID: 37167 RVA: 0x000D014D File Offset: 0x000CE34D
		public unsafe string VertexColorViewModeMaterialName_BlueOnly
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_VertexColorViewModeMaterialName_BlueOnly)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_VertexColorViewModeMaterialName_BlueOnly)), value);
			}
		}

		// Token: 0x1700227C RID: 8828
		// (get) Token: 0x06009130 RID: 37168 RVA: 0x000D0162 File Offset: 0x000CE362
		// (set) Token: 0x06009131 RID: 37169 RVA: 0x000D0176 File Offset: 0x000CE376
		[Nullable(2)]
		public unsafe UMaterial VertexColorViewModeMaterial_FlowArrow
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_VertexColorViewModeMaterial_FlowArrow);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_VertexColorViewModeMaterial_FlowArrow, value);
			}
		}

		// Token: 0x1700227D RID: 8829
		// (get) Token: 0x06009132 RID: 37170 RVA: 0x000D018B File Offset: 0x000CE38B
		// (set) Token: 0x06009133 RID: 37171 RVA: 0x000D019F File Offset: 0x000CE39F
		public unsafe string VertexColorViewModeMaterialName_FlowArrow
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_VertexColorViewModeMaterialName_FlowArrow)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_VertexColorViewModeMaterialName_FlowArrow)), value);
			}
		}

		// Token: 0x1700227E RID: 8830
		// (get) Token: 0x06009134 RID: 37172 RVA: 0x000D01B4 File Offset: 0x000CE3B4
		// (set) Token: 0x06009135 RID: 37173 RVA: 0x000D01C8 File Offset: 0x000CE3C8
		[Nullable(2)]
		public unsafe UMaterial VertexColorViewModeMaterial_FlowWater
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_VertexColorViewModeMaterial_FlowWater);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_VertexColorViewModeMaterial_FlowWater, value);
			}
		}

		// Token: 0x1700227F RID: 8831
		// (get) Token: 0x06009136 RID: 37174 RVA: 0x000D01DD File Offset: 0x000CE3DD
		// (set) Token: 0x06009137 RID: 37175 RVA: 0x000D01F1 File Offset: 0x000CE3F1
		public unsafe string VertexColorViewModeMaterialName_FlowWater
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_VertexColorViewModeMaterialName_FlowWater)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_VertexColorViewModeMaterialName_FlowWater)), value);
			}
		}

		// Token: 0x17002280 RID: 8832
		// (get) Token: 0x06009138 RID: 37176 RVA: 0x000D0208 File Offset: 0x000CE408
		// (set) Token: 0x06009139 RID: 37177 RVA: 0x000D0241 File Offset: 0x000CE441
		public FSoftObjectPath DebugEditorMaterialName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._DebugEditorMaterialName) == null)
				{
					result = (this._DebugEditorMaterialName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DebugEditorMaterialName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DebugEditorMaterialName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002281 RID: 8833
		// (get) Token: 0x0600913A RID: 37178 RVA: 0x000D0262 File Offset: 0x000CE462
		// (set) Token: 0x0600913B RID: 37179 RVA: 0x000D0276 File Offset: 0x000CE476
		[Nullable(2)]
		public unsafe UMaterial ConstraintLimitMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ConstraintLimitMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ConstraintLimitMaterial, value);
			}
		}

		// Token: 0x17002282 RID: 8834
		// (get) Token: 0x0600913C RID: 37180 RVA: 0x000D028B File Offset: 0x000CE48B
		// (set) Token: 0x0600913D RID: 37181 RVA: 0x000D029F File Offset: 0x000CE49F
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic ConstraintLimitMaterialX
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ConstraintLimitMaterialX);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ConstraintLimitMaterialX, value);
			}
		}

		// Token: 0x17002283 RID: 8835
		// (get) Token: 0x0600913E RID: 37182 RVA: 0x000D02B4 File Offset: 0x000CE4B4
		// (set) Token: 0x0600913F RID: 37183 RVA: 0x000D02C8 File Offset: 0x000CE4C8
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic ConstraintLimitMaterialXAxis
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ConstraintLimitMaterialXAxis);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ConstraintLimitMaterialXAxis, value);
			}
		}

		// Token: 0x17002284 RID: 8836
		// (get) Token: 0x06009140 RID: 37184 RVA: 0x000D02DD File Offset: 0x000CE4DD
		// (set) Token: 0x06009141 RID: 37185 RVA: 0x000D02F1 File Offset: 0x000CE4F1
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic ConstraintLimitMaterialY
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ConstraintLimitMaterialY);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ConstraintLimitMaterialY, value);
			}
		}

		// Token: 0x17002285 RID: 8837
		// (get) Token: 0x06009142 RID: 37186 RVA: 0x000D0306 File Offset: 0x000CE506
		// (set) Token: 0x06009143 RID: 37187 RVA: 0x000D031A File Offset: 0x000CE51A
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic ConstraintLimitMaterialYAxis
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ConstraintLimitMaterialYAxis);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ConstraintLimitMaterialYAxis, value);
			}
		}

		// Token: 0x17002286 RID: 8838
		// (get) Token: 0x06009144 RID: 37188 RVA: 0x000D032F File Offset: 0x000CE52F
		// (set) Token: 0x06009145 RID: 37189 RVA: 0x000D0343 File Offset: 0x000CE543
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic ConstraintLimitMaterialZ
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ConstraintLimitMaterialZ);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ConstraintLimitMaterialZ, value);
			}
		}

		// Token: 0x17002287 RID: 8839
		// (get) Token: 0x06009146 RID: 37190 RVA: 0x000D0358 File Offset: 0x000CE558
		// (set) Token: 0x06009147 RID: 37191 RVA: 0x000D036C File Offset: 0x000CE56C
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic ConstraintLimitMaterialZAxis
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ConstraintLimitMaterialZAxis);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ConstraintLimitMaterialZAxis, value);
			}
		}

		// Token: 0x17002288 RID: 8840
		// (get) Token: 0x06009148 RID: 37192 RVA: 0x000D0381 File Offset: 0x000CE581
		// (set) Token: 0x06009149 RID: 37193 RVA: 0x000D0395 File Offset: 0x000CE595
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic ConstraintLimitMaterialPrismatic
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ConstraintLimitMaterialPrismatic);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ConstraintLimitMaterialPrismatic, value);
			}
		}

		// Token: 0x17002289 RID: 8841
		// (get) Token: 0x0600914A RID: 37194 RVA: 0x000D03AA File Offset: 0x000CE5AA
		// (set) Token: 0x0600914B RID: 37195 RVA: 0x000D03BE File Offset: 0x000CE5BE
		[Nullable(2)]
		public unsafe UMaterial InvalidLightmapSettingsMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_InvalidLightmapSettingsMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_InvalidLightmapSettingsMaterial, value);
			}
		}

		// Token: 0x1700228A RID: 8842
		// (get) Token: 0x0600914C RID: 37196 RVA: 0x000D03D4 File Offset: 0x000CE5D4
		// (set) Token: 0x0600914D RID: 37197 RVA: 0x000D040D File Offset: 0x000CE60D
		public FSoftObjectPath InvalidLightmapSettingsMaterialName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._InvalidLightmapSettingsMaterialName) == null)
				{
					result = (this._InvalidLightmapSettingsMaterialName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_InvalidLightmapSettingsMaterialName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_InvalidLightmapSettingsMaterialName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700228B RID: 8843
		// (get) Token: 0x0600914E RID: 37198 RVA: 0x000D042E File Offset: 0x000CE62E
		// (set) Token: 0x0600914F RID: 37199 RVA: 0x000D0442 File Offset: 0x000CE642
		[Nullable(2)]
		public unsafe UMaterial PreviewShadowsIndicatorMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_PreviewShadowsIndicatorMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_PreviewShadowsIndicatorMaterial, value);
			}
		}

		// Token: 0x1700228C RID: 8844
		// (get) Token: 0x06009150 RID: 37200 RVA: 0x000D0458 File Offset: 0x000CE658
		// (set) Token: 0x06009151 RID: 37201 RVA: 0x000D0491 File Offset: 0x000CE691
		public FSoftObjectPath PreviewShadowsIndicatorMaterialName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._PreviewShadowsIndicatorMaterialName) == null)
				{
					result = (this._PreviewShadowsIndicatorMaterialName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_PreviewShadowsIndicatorMaterialName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_PreviewShadowsIndicatorMaterialName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700228D RID: 8845
		// (get) Token: 0x06009152 RID: 37202 RVA: 0x000D04B2 File Offset: 0x000CE6B2
		// (set) Token: 0x06009153 RID: 37203 RVA: 0x000D04C6 File Offset: 0x000CE6C6
		[Nullable(2)]
		public unsafe UMaterial ArrowMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ArrowMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ArrowMaterial, value);
			}
		}

		// Token: 0x1700228E RID: 8846
		// (get) Token: 0x06009154 RID: 37204 RVA: 0x000D04DB File Offset: 0x000CE6DB
		// (set) Token: 0x06009155 RID: 37205 RVA: 0x000D04EF File Offset: 0x000CE6EF
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic ArrowMaterialYellow
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ArrowMaterialYellow);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_ArrowMaterialYellow, value);
			}
		}

		// Token: 0x1700228F RID: 8847
		// (get) Token: 0x06009156 RID: 37206 RVA: 0x000D0504 File Offset: 0x000CE704
		// (set) Token: 0x06009157 RID: 37207 RVA: 0x000D053D File Offset: 0x000CE73D
		public FSoftObjectPath ArrowMaterialName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._ArrowMaterialName) == null)
				{
					result = (this._ArrowMaterialName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_ArrowMaterialName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_ArrowMaterialName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002290 RID: 8848
		// (get) Token: 0x06009158 RID: 37208 RVA: 0x000D055E File Offset: 0x000CE75E
		// (set) Token: 0x06009159 RID: 37209 RVA: 0x000D0572 File Offset: 0x000CE772
		public unsafe FLinearColor LightingOnlyBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_LightingOnlyBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_LightingOnlyBrightness) = value;
			}
		}

		// Token: 0x17002291 RID: 8849
		// (get) Token: 0x0600915A RID: 37210 RVA: 0x000D0588 File Offset: 0x000CE788
		// (set) Token: 0x0600915B RID: 37211 RVA: 0x000D05C1 File Offset: 0x000CE7C1
		public TArray<FLinearColor> ShaderComplexityColors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._ShaderComplexityColors) == null)
				{
					result = (this._ShaderComplexityColors = new TArray<FLinearColor>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_ShaderComplexityColors, this));
				}
				return result;
			}
			set
			{
				this.ShaderComplexityColors.CopyAssign(value);
			}
		}

		// Token: 0x17002292 RID: 8850
		// (get) Token: 0x0600915C RID: 37212 RVA: 0x000D05D0 File Offset: 0x000CE7D0
		// (set) Token: 0x0600915D RID: 37213 RVA: 0x000D0609 File Offset: 0x000CE809
		public TArray<FLinearColor> QuadComplexityColors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._QuadComplexityColors) == null)
				{
					result = (this._QuadComplexityColors = new TArray<FLinearColor>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_QuadComplexityColors, this));
				}
				return result;
			}
			set
			{
				this.QuadComplexityColors.CopyAssign(value);
			}
		}

		// Token: 0x17002293 RID: 8851
		// (get) Token: 0x0600915E RID: 37214 RVA: 0x000D0618 File Offset: 0x000CE818
		// (set) Token: 0x0600915F RID: 37215 RVA: 0x000D0651 File Offset: 0x000CE851
		public TArray<FLinearColor> LightComplexityColors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._LightComplexityColors) == null)
				{
					result = (this._LightComplexityColors = new TArray<FLinearColor>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_LightComplexityColors, this));
				}
				return result;
			}
			set
			{
				this.LightComplexityColors.CopyAssign(value);
			}
		}

		// Token: 0x17002294 RID: 8852
		// (get) Token: 0x06009160 RID: 37216 RVA: 0x000D0660 File Offset: 0x000CE860
		// (set) Token: 0x06009161 RID: 37217 RVA: 0x000D0699 File Offset: 0x000CE899
		public TArray<FLinearColor> StationaryLightOverlapColors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._StationaryLightOverlapColors) == null)
				{
					result = (this._StationaryLightOverlapColors = new TArray<FLinearColor>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_StationaryLightOverlapColors, this));
				}
				return result;
			}
			set
			{
				this.StationaryLightOverlapColors.CopyAssign(value);
			}
		}

		// Token: 0x17002295 RID: 8853
		// (get) Token: 0x06009162 RID: 37218 RVA: 0x000D06A8 File Offset: 0x000CE8A8
		// (set) Token: 0x06009163 RID: 37219 RVA: 0x000D06E1 File Offset: 0x000CE8E1
		public TArray<FLinearColor> LODColorationColors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._LODColorationColors) == null)
				{
					result = (this._LODColorationColors = new TArray<FLinearColor>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_LODColorationColors, this));
				}
				return result;
			}
			set
			{
				this.LODColorationColors.CopyAssign(value);
			}
		}

		// Token: 0x17002296 RID: 8854
		// (get) Token: 0x06009164 RID: 37220 RVA: 0x000D06F0 File Offset: 0x000CE8F0
		// (set) Token: 0x06009165 RID: 37221 RVA: 0x000D0729 File Offset: 0x000CE929
		public TArray<FLinearColor> HLODColorationColors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._HLODColorationColors) == null)
				{
					result = (this._HLODColorationColors = new TArray<FLinearColor>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_HLODColorationColors, this));
				}
				return result;
			}
			set
			{
				this.HLODColorationColors.CopyAssign(value);
			}
		}

		// Token: 0x17002297 RID: 8855
		// (get) Token: 0x06009166 RID: 37222 RVA: 0x000D0738 File Offset: 0x000CE938
		// (set) Token: 0x06009167 RID: 37223 RVA: 0x000D0771 File Offset: 0x000CE971
		public TArray<FLinearColor> StreamingAccuracyColors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._StreamingAccuracyColors) == null)
				{
					result = (this._StreamingAccuracyColors = new TArray<FLinearColor>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_StreamingAccuracyColors, this));
				}
				return result;
			}
			set
			{
				this.StreamingAccuracyColors.CopyAssign(value);
			}
		}

		// Token: 0x17002298 RID: 8856
		// (get) Token: 0x06009168 RID: 37224 RVA: 0x000D077F File Offset: 0x000CE97F
		// (set) Token: 0x06009169 RID: 37225 RVA: 0x000D078F File Offset: 0x000CE98F
		public unsafe float MaxPixelShaderAdditiveComplexityCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MaxPixelShaderAdditiveComplexityCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MaxPixelShaderAdditiveComplexityCount) = value;
			}
		}

		// Token: 0x17002299 RID: 8857
		// (get) Token: 0x0600916A RID: 37226 RVA: 0x000D07A0 File Offset: 0x000CE9A0
		// (set) Token: 0x0600916B RID: 37227 RVA: 0x000D07B0 File Offset: 0x000CE9B0
		public unsafe float MaxES3PixelShaderAdditiveComplexityCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MaxES3PixelShaderAdditiveComplexityCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MaxES3PixelShaderAdditiveComplexityCount) = value;
			}
		}

		// Token: 0x1700229A RID: 8858
		// (get) Token: 0x0600916C RID: 37228 RVA: 0x000D07C1 File Offset: 0x000CE9C1
		// (set) Token: 0x0600916D RID: 37229 RVA: 0x000D07D1 File Offset: 0x000CE9D1
		public unsafe float MinLightMapDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MinLightMapDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MinLightMapDensity) = value;
			}
		}

		// Token: 0x1700229B RID: 8859
		// (get) Token: 0x0600916E RID: 37230 RVA: 0x000D07E2 File Offset: 0x000CE9E2
		// (set) Token: 0x0600916F RID: 37231 RVA: 0x000D07F2 File Offset: 0x000CE9F2
		public unsafe float IdealLightMapDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_IdealLightMapDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_IdealLightMapDensity) = value;
			}
		}

		// Token: 0x1700229C RID: 8860
		// (get) Token: 0x06009170 RID: 37232 RVA: 0x000D0803 File Offset: 0x000CEA03
		// (set) Token: 0x06009171 RID: 37233 RVA: 0x000D0813 File Offset: 0x000CEA13
		public unsafe float MaxLightMapDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MaxLightMapDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MaxLightMapDensity) = value;
			}
		}

		// Token: 0x1700229D RID: 8861
		// (get) Token: 0x06009172 RID: 37234 RVA: 0x000D0824 File Offset: 0x000CEA24
		// (set) Token: 0x06009173 RID: 37235 RVA: 0x000D083D File Offset: 0x000CEA3D
		public unsafe bool bRenderLightMapDensityGrayscale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bRenderLightMapDensityGrayscale) & UEngine.__PropertyMask_bRenderLightMapDensityGrayscale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEngine.__PropertyOffset_bRenderLightMapDensityGrayscale) = ((*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bRenderLightMapDensityGrayscale) & ~UEngine.__PropertyMask_bRenderLightMapDensityGrayscale) | (value ? UEngine.__PropertyMask_bRenderLightMapDensityGrayscale : 0));
			}
		}

		// Token: 0x1700229E RID: 8862
		// (get) Token: 0x06009174 RID: 37236 RVA: 0x000D086D File Offset: 0x000CEA6D
		// (set) Token: 0x06009175 RID: 37237 RVA: 0x000D087D File Offset: 0x000CEA7D
		public unsafe float RenderLightMapDensityGrayscaleScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_RenderLightMapDensityGrayscaleScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_RenderLightMapDensityGrayscaleScale) = value;
			}
		}

		// Token: 0x1700229F RID: 8863
		// (get) Token: 0x06009176 RID: 37238 RVA: 0x000D088E File Offset: 0x000CEA8E
		// (set) Token: 0x06009177 RID: 37239 RVA: 0x000D089E File Offset: 0x000CEA9E
		public unsafe float RenderLightMapDensityColorScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_RenderLightMapDensityColorScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_RenderLightMapDensityColorScale) = value;
			}
		}

		// Token: 0x170022A0 RID: 8864
		// (get) Token: 0x06009178 RID: 37240 RVA: 0x000D08AF File Offset: 0x000CEAAF
		// (set) Token: 0x06009179 RID: 37241 RVA: 0x000D08C3 File Offset: 0x000CEAC3
		public unsafe FLinearColor LightMapDensityVertexMappedColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_LightMapDensityVertexMappedColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_LightMapDensityVertexMappedColor) = value;
			}
		}

		// Token: 0x170022A1 RID: 8865
		// (get) Token: 0x0600917A RID: 37242 RVA: 0x000D08D8 File Offset: 0x000CEAD8
		// (set) Token: 0x0600917B RID: 37243 RVA: 0x000D08EC File Offset: 0x000CEAEC
		public unsafe FLinearColor LightMapDensitySelectedColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_LightMapDensitySelectedColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_LightMapDensitySelectedColor) = value;
			}
		}

		// Token: 0x170022A2 RID: 8866
		// (get) Token: 0x0600917C RID: 37244 RVA: 0x000D0904 File Offset: 0x000CEB04
		// (set) Token: 0x0600917D RID: 37245 RVA: 0x000D093D File Offset: 0x000CEB3D
		public TArray<FStatColorMapping> StatColorMappings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FStatColorMapping> result;
				if ((result = this._StatColorMappings) == null)
				{
					result = (this._StatColorMappings = new TArray<FStatColorMapping>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_StatColorMappings, this));
				}
				return result;
			}
			set
			{
				this.StatColorMappings.CopyAssign(value);
			}
		}

		// Token: 0x170022A3 RID: 8867
		// (get) Token: 0x0600917E RID: 37246 RVA: 0x000D094B File Offset: 0x000CEB4B
		// (set) Token: 0x0600917F RID: 37247 RVA: 0x000D095F File Offset: 0x000CEB5F
		[Nullable(2)]
		public unsafe UPhysicalMaterial DefaultPhysMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_DefaultPhysMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_DefaultPhysMaterial, value);
			}
		}

		// Token: 0x170022A4 RID: 8868
		// (get) Token: 0x06009180 RID: 37248 RVA: 0x000D0974 File Offset: 0x000CEB74
		// (set) Token: 0x06009181 RID: 37249 RVA: 0x000D09AD File Offset: 0x000CEBAD
		public FSoftObjectPath DefaultPhysMaterialName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._DefaultPhysMaterialName) == null)
				{
					result = (this._DefaultPhysMaterialName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DefaultPhysMaterialName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DefaultPhysMaterialName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170022A5 RID: 8869
		// (get) Token: 0x06009182 RID: 37250 RVA: 0x000D09D0 File Offset: 0x000CEBD0
		// (set) Token: 0x06009183 RID: 37251 RVA: 0x000D0A09 File Offset: 0x000CEC09
		public TArray<FGameNameRedirect> ActiveGameNameRedirects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameNameRedirect> result;
				if ((result = this._ActiveGameNameRedirects) == null)
				{
					result = (this._ActiveGameNameRedirects = new TArray<FGameNameRedirect>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_ActiveGameNameRedirects, this));
				}
				return result;
			}
			set
			{
				this.ActiveGameNameRedirects.CopyAssign(value);
			}
		}

		// Token: 0x170022A6 RID: 8870
		// (get) Token: 0x06009184 RID: 37252 RVA: 0x000D0A18 File Offset: 0x000CEC18
		// (set) Token: 0x06009185 RID: 37253 RVA: 0x000D0A51 File Offset: 0x000CEC51
		public TArray<FClassRedirect> ActiveClassRedirects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FClassRedirect> result;
				if ((result = this._ActiveClassRedirects) == null)
				{
					result = (this._ActiveClassRedirects = new TArray<FClassRedirect>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_ActiveClassRedirects, this));
				}
				return result;
			}
			set
			{
				this.ActiveClassRedirects.CopyAssign(value);
			}
		}

		// Token: 0x170022A7 RID: 8871
		// (get) Token: 0x06009186 RID: 37254 RVA: 0x000D0A60 File Offset: 0x000CEC60
		// (set) Token: 0x06009187 RID: 37255 RVA: 0x000D0A99 File Offset: 0x000CEC99
		public TArray<FPluginRedirect> ActivePluginRedirects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPluginRedirect> result;
				if ((result = this._ActivePluginRedirects) == null)
				{
					result = (this._ActivePluginRedirects = new TArray<FPluginRedirect>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_ActivePluginRedirects, this));
				}
				return result;
			}
			set
			{
				this.ActivePluginRedirects.CopyAssign(value);
			}
		}

		// Token: 0x170022A8 RID: 8872
		// (get) Token: 0x06009188 RID: 37256 RVA: 0x000D0AA8 File Offset: 0x000CECA8
		// (set) Token: 0x06009189 RID: 37257 RVA: 0x000D0AE1 File Offset: 0x000CECE1
		public TArray<FStructRedirect> ActiveStructRedirects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FStructRedirect> result;
				if ((result = this._ActiveStructRedirects) == null)
				{
					result = (this._ActiveStructRedirects = new TArray<FStructRedirect>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_ActiveStructRedirects, this));
				}
				return result;
			}
			set
			{
				this.ActiveStructRedirects.CopyAssign(value);
			}
		}

		// Token: 0x170022A9 RID: 8873
		// (get) Token: 0x0600918A RID: 37258 RVA: 0x000D0AEF File Offset: 0x000CECEF
		// (set) Token: 0x0600918B RID: 37259 RVA: 0x000D0B03 File Offset: 0x000CED03
		[Nullable(2)]
		public unsafe UTexture2D PreIntegratedSnowBRDFTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_PreIntegratedSnowBRDFTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_PreIntegratedSnowBRDFTexture, value);
			}
		}

		// Token: 0x170022AA RID: 8874
		// (get) Token: 0x0600918C RID: 37260 RVA: 0x000D0B18 File Offset: 0x000CED18
		// (set) Token: 0x0600918D RID: 37261 RVA: 0x000D0B51 File Offset: 0x000CED51
		public FSoftObjectPath PreIntegratedSnowBRDFTextureName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._PreIntegratedSnowBRDFTextureName) == null)
				{
					result = (this._PreIntegratedSnowBRDFTextureName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_PreIntegratedSnowBRDFTextureName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_PreIntegratedSnowBRDFTextureName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170022AB RID: 8875
		// (get) Token: 0x0600918E RID: 37262 RVA: 0x000D0B72 File Offset: 0x000CED72
		// (set) Token: 0x0600918F RID: 37263 RVA: 0x000D0B86 File Offset: 0x000CED86
		[Nullable(2)]
		public unsafe UTexture2D BlueNoiseTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_BlueNoiseTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_BlueNoiseTexture, value);
			}
		}

		// Token: 0x170022AC RID: 8876
		// (get) Token: 0x06009190 RID: 37264 RVA: 0x000D0B9C File Offset: 0x000CED9C
		// (set) Token: 0x06009191 RID: 37265 RVA: 0x000D0BD5 File Offset: 0x000CEDD5
		public FSoftObjectPath BlueNoiseTextureName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._BlueNoiseTextureName) == null)
				{
					result = (this._BlueNoiseTextureName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_BlueNoiseTextureName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_BlueNoiseTextureName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170022AD RID: 8877
		// (get) Token: 0x06009192 RID: 37266 RVA: 0x000D0BF6 File Offset: 0x000CEDF6
		// (set) Token: 0x06009193 RID: 37267 RVA: 0x000D0C0A File Offset: 0x000CEE0A
		[Nullable(2)]
		public unsafe UTexture2D BlueNoiseScalarTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_BlueNoiseScalarTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_BlueNoiseScalarTexture, value);
			}
		}

		// Token: 0x170022AE RID: 8878
		// (get) Token: 0x06009194 RID: 37268 RVA: 0x000D0C20 File Offset: 0x000CEE20
		// (set) Token: 0x06009195 RID: 37269 RVA: 0x000D0C59 File Offset: 0x000CEE59
		public FSoftObjectPath BlueNoiseScalarTextureName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._BlueNoiseScalarTextureName) == null)
				{
					result = (this._BlueNoiseScalarTextureName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_BlueNoiseScalarTextureName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_BlueNoiseScalarTextureName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170022AF RID: 8879
		// (get) Token: 0x06009196 RID: 37270 RVA: 0x000D0C7A File Offset: 0x000CEE7A
		// (set) Token: 0x06009197 RID: 37271 RVA: 0x000D0C8E File Offset: 0x000CEE8E
		[Nullable(2)]
		public unsafe UTexture2D BlueNoiseVec2Texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_BlueNoiseVec2Texture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_BlueNoiseVec2Texture, value);
			}
		}

		// Token: 0x170022B0 RID: 8880
		// (get) Token: 0x06009198 RID: 37272 RVA: 0x000D0CA4 File Offset: 0x000CEEA4
		// (set) Token: 0x06009199 RID: 37273 RVA: 0x000D0CDD File Offset: 0x000CEEDD
		public FSoftObjectPath BlueNoiseVec2TextureName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._BlueNoiseVec2TextureName) == null)
				{
					result = (this._BlueNoiseVec2TextureName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_BlueNoiseVec2TextureName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_BlueNoiseVec2TextureName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170022B1 RID: 8881
		// (get) Token: 0x0600919A RID: 37274 RVA: 0x000D0CFE File Offset: 0x000CEEFE
		// (set) Token: 0x0600919B RID: 37275 RVA: 0x000D0D12 File Offset: 0x000CEF12
		[Nullable(2)]
		public unsafe UBakedBoneTexture2D DefaultBakedBoneTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBakedBoneTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_DefaultBakedBoneTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_DefaultBakedBoneTexture, value);
			}
		}

		// Token: 0x170022B2 RID: 8882
		// (get) Token: 0x0600919C RID: 37276 RVA: 0x000D0D28 File Offset: 0x000CEF28
		// (set) Token: 0x0600919D RID: 37277 RVA: 0x000D0D61 File Offset: 0x000CEF61
		public FSoftObjectPath DefaultBakedBoneTextureName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._DefaultBakedBoneTextureName) == null)
				{
					result = (this._DefaultBakedBoneTextureName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DefaultBakedBoneTextureName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DefaultBakedBoneTextureName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170022B3 RID: 8883
		// (get) Token: 0x0600919E RID: 37278 RVA: 0x000D0D82 File Offset: 0x000CEF82
		// (set) Token: 0x0600919F RID: 37279 RVA: 0x000D0D96 File Offset: 0x000CEF96
		[Nullable(2)]
		public unsafe UTexture2D DefaultAnimNoiseTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_DefaultAnimNoiseTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_DefaultAnimNoiseTexture, value);
			}
		}

		// Token: 0x170022B4 RID: 8884
		// (get) Token: 0x060091A0 RID: 37280 RVA: 0x000D0DAC File Offset: 0x000CEFAC
		// (set) Token: 0x060091A1 RID: 37281 RVA: 0x000D0DE5 File Offset: 0x000CEFE5
		public FSoftObjectPath DefaultAnimNoiseTextureName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._DefaultAnimNoiseTextureName) == null)
				{
					result = (this._DefaultAnimNoiseTextureName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DefaultAnimNoiseTextureName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DefaultAnimNoiseTextureName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170022B5 RID: 8885
		// (get) Token: 0x060091A2 RID: 37282 RVA: 0x000D0E06 File Offset: 0x000CF006
		// (set) Token: 0x060091A3 RID: 37283 RVA: 0x000D0E1A File Offset: 0x000CF01A
		[Nullable(2)]
		public unsafe UTexture2D MiniFontTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_MiniFontTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_MiniFontTexture, value);
			}
		}

		// Token: 0x170022B6 RID: 8886
		// (get) Token: 0x060091A4 RID: 37284 RVA: 0x000D0E30 File Offset: 0x000CF030
		// (set) Token: 0x060091A5 RID: 37285 RVA: 0x000D0E69 File Offset: 0x000CF069
		public FSoftObjectPath MiniFontTextureName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._MiniFontTextureName) == null)
				{
					result = (this._MiniFontTextureName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MiniFontTextureName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MiniFontTextureName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170022B7 RID: 8887
		// (get) Token: 0x060091A6 RID: 37286 RVA: 0x000D0E8A File Offset: 0x000CF08A
		// (set) Token: 0x060091A7 RID: 37287 RVA: 0x000D0E9E File Offset: 0x000CF09E
		[Nullable(2)]
		public unsafe UTexture WeightMapPlaceholderTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_WeightMapPlaceholderTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_WeightMapPlaceholderTexture, value);
			}
		}

		// Token: 0x170022B8 RID: 8888
		// (get) Token: 0x060091A8 RID: 37288 RVA: 0x000D0EB4 File Offset: 0x000CF0B4
		// (set) Token: 0x060091A9 RID: 37289 RVA: 0x000D0EED File Offset: 0x000CF0ED
		public FSoftObjectPath WeightMapPlaceholderTextureName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._WeightMapPlaceholderTextureName) == null)
				{
					result = (this._WeightMapPlaceholderTextureName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_WeightMapPlaceholderTextureName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_WeightMapPlaceholderTextureName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170022B9 RID: 8889
		// (get) Token: 0x060091AA RID: 37290 RVA: 0x000D0F0E File Offset: 0x000CF10E
		// (set) Token: 0x060091AB RID: 37291 RVA: 0x000D0F22 File Offset: 0x000CF122
		[Nullable(2)]
		public unsafe UTexture2D LightMapDensityTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_LightMapDensityTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_LightMapDensityTexture, value);
			}
		}

		// Token: 0x170022BA RID: 8890
		// (get) Token: 0x060091AC RID: 37292 RVA: 0x000D0F38 File Offset: 0x000CF138
		// (set) Token: 0x060091AD RID: 37293 RVA: 0x000D0F71 File Offset: 0x000CF171
		public FSoftObjectPath LightMapDensityTextureName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._LightMapDensityTextureName) == null)
				{
					result = (this._LightMapDensityTextureName = new FSoftObjectPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_LightMapDensityTextureName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_LightMapDensityTextureName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170022BB RID: 8891
		// (get) Token: 0x060091AE RID: 37294 RVA: 0x000D0F92 File Offset: 0x000CF192
		// (set) Token: 0x060091AF RID: 37295 RVA: 0x000D0FA6 File Offset: 0x000CF1A6
		[Nullable(2)]
		public unsafe UTexture2D BlackTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_BlackTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_BlackTexture, value);
			}
		}

		// Token: 0x170022BC RID: 8892
		// (get) Token: 0x060091B0 RID: 37296 RVA: 0x000D0FBB File Offset: 0x000CF1BB
		// (set) Token: 0x060091B1 RID: 37297 RVA: 0x000D0FCF File Offset: 0x000CF1CF
		[Nullable(2)]
		public unsafe UGameViewportClient GameViewport
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameViewportClient>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_GameViewport);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_GameViewport, value);
			}
		}

		// Token: 0x170022BD RID: 8893
		// (get) Token: 0x060091B2 RID: 37298 RVA: 0x000D0FE4 File Offset: 0x000CF1E4
		// (set) Token: 0x060091B3 RID: 37299 RVA: 0x000D101D File Offset: 0x000CF21D
		public TArray<string> DeferredCommands
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._DeferredCommands) == null)
				{
					result = (this._DeferredCommands = new TArray<string>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DeferredCommands, this));
				}
				return result;
			}
			set
			{
				this.DeferredCommands.CopyAssign(value);
			}
		}

		// Token: 0x170022BE RID: 8894
		// (get) Token: 0x060091B4 RID: 37300 RVA: 0x000D102B File Offset: 0x000CF22B
		// (set) Token: 0x060091B5 RID: 37301 RVA: 0x000D103B File Offset: 0x000CF23B
		public unsafe float NearClipPlane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_NearClipPlane);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_NearClipPlane) = value;
			}
		}

		// Token: 0x170022BF RID: 8895
		// (get) Token: 0x060091B6 RID: 37302 RVA: 0x000D104C File Offset: 0x000CF24C
		// (set) Token: 0x060091B7 RID: 37303 RVA: 0x000D1065 File Offset: 0x000CF265
		public unsafe bool bSubtitlesEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bSubtitlesEnabled) & UEngine.__PropertyMask_bSubtitlesEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEngine.__PropertyOffset_bSubtitlesEnabled) = ((*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bSubtitlesEnabled) & ~UEngine.__PropertyMask_bSubtitlesEnabled) | (value ? UEngine.__PropertyMask_bSubtitlesEnabled : 0));
			}
		}

		// Token: 0x170022C0 RID: 8896
		// (get) Token: 0x060091B8 RID: 37304 RVA: 0x000D1095 File Offset: 0x000CF295
		// (set) Token: 0x060091B9 RID: 37305 RVA: 0x000D10AE File Offset: 0x000CF2AE
		public unsafe bool bSubtitlesForcedOff
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bSubtitlesForcedOff) & UEngine.__PropertyMask_bSubtitlesForcedOff) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEngine.__PropertyOffset_bSubtitlesForcedOff) = ((*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bSubtitlesForcedOff) & ~UEngine.__PropertyMask_bSubtitlesForcedOff) | (value ? UEngine.__PropertyMask_bSubtitlesForcedOff : 0));
			}
		}

		// Token: 0x170022C1 RID: 8897
		// (get) Token: 0x060091BA RID: 37306 RVA: 0x000D10DE File Offset: 0x000CF2DE
		// (set) Token: 0x060091BB RID: 37307 RVA: 0x000D10EE File Offset: 0x000CF2EE
		public unsafe int MaximumLoopIterationCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MaximumLoopIterationCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MaximumLoopIterationCount) = value;
			}
		}

		// Token: 0x170022C2 RID: 8898
		// (get) Token: 0x060091BC RID: 37308 RVA: 0x000D10FF File Offset: 0x000CF2FF
		// (set) Token: 0x060091BD RID: 37309 RVA: 0x000D1118 File Offset: 0x000CF318
		public unsafe bool bCanBlueprintsTickByDefault
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bCanBlueprintsTickByDefault) & UEngine.__PropertyMask_bCanBlueprintsTickByDefault) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEngine.__PropertyOffset_bCanBlueprintsTickByDefault) = ((*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bCanBlueprintsTickByDefault) & ~UEngine.__PropertyMask_bCanBlueprintsTickByDefault) | (value ? UEngine.__PropertyMask_bCanBlueprintsTickByDefault : 0));
			}
		}

		// Token: 0x170022C3 RID: 8899
		// (get) Token: 0x060091BE RID: 37310 RVA: 0x000D1148 File Offset: 0x000CF348
		// (set) Token: 0x060091BF RID: 37311 RVA: 0x000D1161 File Offset: 0x000CF361
		public unsafe bool bOptimizeAnimBlueprintMemberVariableAccess
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bOptimizeAnimBlueprintMemberVariableAccess) & UEngine.__PropertyMask_bOptimizeAnimBlueprintMemberVariableAccess) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEngine.__PropertyOffset_bOptimizeAnimBlueprintMemberVariableAccess) = ((*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bOptimizeAnimBlueprintMemberVariableAccess) & ~UEngine.__PropertyMask_bOptimizeAnimBlueprintMemberVariableAccess) | (value ? UEngine.__PropertyMask_bOptimizeAnimBlueprintMemberVariableAccess : 0));
			}
		}

		// Token: 0x170022C4 RID: 8900
		// (get) Token: 0x060091C0 RID: 37312 RVA: 0x000D1191 File Offset: 0x000CF391
		// (set) Token: 0x060091C1 RID: 37313 RVA: 0x000D11AA File Offset: 0x000CF3AA
		public unsafe bool bAllowMultiThreadedAnimationUpdate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bAllowMultiThreadedAnimationUpdate) & UEngine.__PropertyMask_bAllowMultiThreadedAnimationUpdate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEngine.__PropertyOffset_bAllowMultiThreadedAnimationUpdate) = ((*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bAllowMultiThreadedAnimationUpdate) & ~UEngine.__PropertyMask_bAllowMultiThreadedAnimationUpdate) | (value ? UEngine.__PropertyMask_bAllowMultiThreadedAnimationUpdate : 0));
			}
		}

		// Token: 0x170022C5 RID: 8901
		// (get) Token: 0x060091C2 RID: 37314 RVA: 0x000D11DA File Offset: 0x000CF3DA
		// (set) Token: 0x060091C3 RID: 37315 RVA: 0x000D11F3 File Offset: 0x000CF3F3
		public unsafe bool bEnableEditorPSysRealtimeLOD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bEnableEditorPSysRealtimeLOD) & UEngine.__PropertyMask_bEnableEditorPSysRealtimeLOD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEngine.__PropertyOffset_bEnableEditorPSysRealtimeLOD) = ((*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bEnableEditorPSysRealtimeLOD) & ~UEngine.__PropertyMask_bEnableEditorPSysRealtimeLOD) | (value ? UEngine.__PropertyMask_bEnableEditorPSysRealtimeLOD : 0));
			}
		}

		// Token: 0x170022C6 RID: 8902
		// (get) Token: 0x060091C4 RID: 37316 RVA: 0x000D1223 File Offset: 0x000CF423
		// (set) Token: 0x060091C5 RID: 37317 RVA: 0x000D123C File Offset: 0x000CF43C
		public unsafe bool bSmoothFrameRate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bSmoothFrameRate) & UEngine.__PropertyMask_bSmoothFrameRate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEngine.__PropertyOffset_bSmoothFrameRate) = ((*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bSmoothFrameRate) & ~UEngine.__PropertyMask_bSmoothFrameRate) | (value ? UEngine.__PropertyMask_bSmoothFrameRate : 0));
			}
		}

		// Token: 0x170022C7 RID: 8903
		// (get) Token: 0x060091C6 RID: 37318 RVA: 0x000D126C File Offset: 0x000CF46C
		// (set) Token: 0x060091C7 RID: 37319 RVA: 0x000D1285 File Offset: 0x000CF485
		public unsafe bool bUseFixedFrameRate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bUseFixedFrameRate) & UEngine.__PropertyMask_bUseFixedFrameRate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEngine.__PropertyOffset_bUseFixedFrameRate) = ((*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bUseFixedFrameRate) & ~UEngine.__PropertyMask_bUseFixedFrameRate) | (value ? UEngine.__PropertyMask_bUseFixedFrameRate : 0));
			}
		}

		// Token: 0x170022C8 RID: 8904
		// (get) Token: 0x060091C8 RID: 37320 RVA: 0x000D12B5 File Offset: 0x000CF4B5
		// (set) Token: 0x060091C9 RID: 37321 RVA: 0x000D12C5 File Offset: 0x000CF4C5
		public unsafe float FixedFrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_FixedFrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_FixedFrameRate) = value;
			}
		}

		// Token: 0x170022C9 RID: 8905
		// (get) Token: 0x060091CA RID: 37322 RVA: 0x000D12D6 File Offset: 0x000CF4D6
		// (set) Token: 0x060091CB RID: 37323 RVA: 0x000D12EA File Offset: 0x000CF4EA
		public unsafe FFloatRange SmoothedFrameRateRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_SmoothedFrameRateRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_SmoothedFrameRateRange) = value;
			}
		}

		// Token: 0x170022CA RID: 8906
		// (get) Token: 0x060091CC RID: 37324 RVA: 0x000D12FF File Offset: 0x000CF4FF
		// (set) Token: 0x060091CD RID: 37325 RVA: 0x000D1313 File Offset: 0x000CF513
		[Nullable(2)]
		public unsafe UEngineCustomTimeStep CustomTimeStep
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEngineCustomTimeStep>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_CustomTimeStep);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_CustomTimeStep, value);
			}
		}

		// Token: 0x170022CB RID: 8907
		// (get) Token: 0x060091CE RID: 37326 RVA: 0x000D1328 File Offset: 0x000CF528
		// (set) Token: 0x060091CF RID: 37327 RVA: 0x000D1361 File Offset: 0x000CF561
		public FSoftClassPath CustomTimeStepClassName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._CustomTimeStepClassName) == null)
				{
					result = (this._CustomTimeStepClassName = new FSoftClassPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_CustomTimeStepClassName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_CustomTimeStepClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170022CC RID: 8908
		// (get) Token: 0x060091D0 RID: 37328 RVA: 0x000D1382 File Offset: 0x000CF582
		// (set) Token: 0x060091D1 RID: 37329 RVA: 0x000D1396 File Offset: 0x000CF596
		[Nullable(2)]
		public unsafe UTimecodeProvider TimecodeProvider
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimecodeProvider>(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_TimecodeProvider);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEngine.__PropertyOffset_TimecodeProvider, value);
			}
		}

		// Token: 0x170022CD RID: 8909
		// (get) Token: 0x060091D2 RID: 37330 RVA: 0x000D13AC File Offset: 0x000CF5AC
		// (set) Token: 0x060091D3 RID: 37331 RVA: 0x000D13E5 File Offset: 0x000CF5E5
		public FSoftClassPath TimecodeProviderClassName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._TimecodeProviderClassName) == null)
				{
					result = (this._TimecodeProviderClassName = new FSoftClassPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_TimecodeProviderClassName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_TimecodeProviderClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170022CE RID: 8910
		// (get) Token: 0x060091D4 RID: 37332 RVA: 0x000D1406 File Offset: 0x000CF606
		// (set) Token: 0x060091D5 RID: 37333 RVA: 0x000D1416 File Offset: 0x000CF616
		public unsafe bool bGenerateDefaultTimecode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bGenerateDefaultTimecode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bGenerateDefaultTimecode) = (value ? 1 : 0);
			}
		}

		// Token: 0x170022CF RID: 8911
		// (get) Token: 0x060091D6 RID: 37334 RVA: 0x000D1427 File Offset: 0x000CF627
		// (set) Token: 0x060091D7 RID: 37335 RVA: 0x000D143B File Offset: 0x000CF63B
		public unsafe FFrameRate GenerateDefaultTimecodeFrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_GenerateDefaultTimecodeFrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_GenerateDefaultTimecodeFrameRate) = value;
			}
		}

		// Token: 0x170022D0 RID: 8912
		// (get) Token: 0x060091D8 RID: 37336 RVA: 0x000D1450 File Offset: 0x000CF650
		// (set) Token: 0x060091D9 RID: 37337 RVA: 0x000D1460 File Offset: 0x000CF660
		public unsafe float GenerateDefaultTimecodeFrameDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_GenerateDefaultTimecodeFrameDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_GenerateDefaultTimecodeFrameDelay) = value;
			}
		}

		// Token: 0x170022D1 RID: 8913
		// (get) Token: 0x060091DA RID: 37338 RVA: 0x000D1471 File Offset: 0x000CF671
		// (set) Token: 0x060091DB RID: 37339 RVA: 0x000D148A File Offset: 0x000CF68A
		public unsafe bool bCheckForMultiplePawnsSpawnedInAFrame
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bCheckForMultiplePawnsSpawnedInAFrame) & UEngine.__PropertyMask_bCheckForMultiplePawnsSpawnedInAFrame) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEngine.__PropertyOffset_bCheckForMultiplePawnsSpawnedInAFrame) = ((*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bCheckForMultiplePawnsSpawnedInAFrame) & ~UEngine.__PropertyMask_bCheckForMultiplePawnsSpawnedInAFrame) | (value ? UEngine.__PropertyMask_bCheckForMultiplePawnsSpawnedInAFrame : 0));
			}
		}

		// Token: 0x170022D2 RID: 8914
		// (get) Token: 0x060091DC RID: 37340 RVA: 0x000D14BA File Offset: 0x000CF6BA
		// (set) Token: 0x060091DD RID: 37341 RVA: 0x000D14CA File Offset: 0x000CF6CA
		public unsafe int NumPawnsAllowedToBeSpawnedInAFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_NumPawnsAllowedToBeSpawnedInAFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_NumPawnsAllowedToBeSpawnedInAFrame) = value;
			}
		}

		// Token: 0x170022D3 RID: 8915
		// (get) Token: 0x060091DE RID: 37342 RVA: 0x000D14DB File Offset: 0x000CF6DB
		// (set) Token: 0x060091DF RID: 37343 RVA: 0x000D14F4 File Offset: 0x000CF6F4
		public unsafe bool bShouldGenerateLowQualityLightmaps_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bShouldGenerateLowQualityLightmaps_DEPRECATED) & UEngine.__PropertyMask_bShouldGenerateLowQualityLightmaps_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEngine.__PropertyOffset_bShouldGenerateLowQualityLightmaps_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bShouldGenerateLowQualityLightmaps_DEPRECATED) & ~UEngine.__PropertyMask_bShouldGenerateLowQualityLightmaps_DEPRECATED) | (value ? UEngine.__PropertyMask_bShouldGenerateLowQualityLightmaps_DEPRECATED : 0));
			}
		}

		// Token: 0x170022D4 RID: 8916
		// (get) Token: 0x060091E0 RID: 37344 RVA: 0x000D1524 File Offset: 0x000CF724
		// (set) Token: 0x060091E1 RID: 37345 RVA: 0x000D1538 File Offset: 0x000CF738
		public unsafe FColor C_WorldBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_WorldBox);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_WorldBox) = value;
			}
		}

		// Token: 0x170022D5 RID: 8917
		// (get) Token: 0x060091E2 RID: 37346 RVA: 0x000D154D File Offset: 0x000CF74D
		// (set) Token: 0x060091E3 RID: 37347 RVA: 0x000D1561 File Offset: 0x000CF761
		public unsafe FColor C_BrushWire
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_BrushWire);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_BrushWire) = value;
			}
		}

		// Token: 0x170022D6 RID: 8918
		// (get) Token: 0x060091E4 RID: 37348 RVA: 0x000D1576 File Offset: 0x000CF776
		// (set) Token: 0x060091E5 RID: 37349 RVA: 0x000D158A File Offset: 0x000CF78A
		public unsafe FColor C_AddWire
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_AddWire);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_AddWire) = value;
			}
		}

		// Token: 0x170022D7 RID: 8919
		// (get) Token: 0x060091E6 RID: 37350 RVA: 0x000D159F File Offset: 0x000CF79F
		// (set) Token: 0x060091E7 RID: 37351 RVA: 0x000D15B3 File Offset: 0x000CF7B3
		public unsafe FColor C_SubtractWire
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_SubtractWire);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_SubtractWire) = value;
			}
		}

		// Token: 0x170022D8 RID: 8920
		// (get) Token: 0x060091E8 RID: 37352 RVA: 0x000D15C8 File Offset: 0x000CF7C8
		// (set) Token: 0x060091E9 RID: 37353 RVA: 0x000D15DC File Offset: 0x000CF7DC
		public unsafe FColor C_SemiSolidWire
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_SemiSolidWire);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_SemiSolidWire) = value;
			}
		}

		// Token: 0x170022D9 RID: 8921
		// (get) Token: 0x060091EA RID: 37354 RVA: 0x000D15F1 File Offset: 0x000CF7F1
		// (set) Token: 0x060091EB RID: 37355 RVA: 0x000D1605 File Offset: 0x000CF805
		public unsafe FColor C_NonSolidWire
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_NonSolidWire);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_NonSolidWire) = value;
			}
		}

		// Token: 0x170022DA RID: 8922
		// (get) Token: 0x060091EC RID: 37356 RVA: 0x000D161A File Offset: 0x000CF81A
		// (set) Token: 0x060091ED RID: 37357 RVA: 0x000D162E File Offset: 0x000CF82E
		public unsafe FColor C_WireBackground
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_WireBackground);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_WireBackground) = value;
			}
		}

		// Token: 0x170022DB RID: 8923
		// (get) Token: 0x060091EE RID: 37358 RVA: 0x000D1643 File Offset: 0x000CF843
		// (set) Token: 0x060091EF RID: 37359 RVA: 0x000D1657 File Offset: 0x000CF857
		public unsafe FColor C_ScaleBoxHi
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_ScaleBoxHi);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_ScaleBoxHi) = value;
			}
		}

		// Token: 0x170022DC RID: 8924
		// (get) Token: 0x060091F0 RID: 37360 RVA: 0x000D166C File Offset: 0x000CF86C
		// (set) Token: 0x060091F1 RID: 37361 RVA: 0x000D1680 File Offset: 0x000CF880
		public unsafe FColor C_VolumeCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_VolumeCollision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_VolumeCollision) = value;
			}
		}

		// Token: 0x170022DD RID: 8925
		// (get) Token: 0x060091F2 RID: 37362 RVA: 0x000D1695 File Offset: 0x000CF895
		// (set) Token: 0x060091F3 RID: 37363 RVA: 0x000D16A9 File Offset: 0x000CF8A9
		public unsafe FColor C_BSPCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_BSPCollision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_BSPCollision) = value;
			}
		}

		// Token: 0x170022DE RID: 8926
		// (get) Token: 0x060091F4 RID: 37364 RVA: 0x000D16BE File Offset: 0x000CF8BE
		// (set) Token: 0x060091F5 RID: 37365 RVA: 0x000D16D2 File Offset: 0x000CF8D2
		public unsafe FColor C_OrthoBackground
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_OrthoBackground);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_OrthoBackground) = value;
			}
		}

		// Token: 0x170022DF RID: 8927
		// (get) Token: 0x060091F6 RID: 37366 RVA: 0x000D16E7 File Offset: 0x000CF8E7
		// (set) Token: 0x060091F7 RID: 37367 RVA: 0x000D16FB File Offset: 0x000CF8FB
		public unsafe FColor C_Volume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_Volume);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_Volume) = value;
			}
		}

		// Token: 0x170022E0 RID: 8928
		// (get) Token: 0x060091F8 RID: 37368 RVA: 0x000D1710 File Offset: 0x000CF910
		// (set) Token: 0x060091F9 RID: 37369 RVA: 0x000D1724 File Offset: 0x000CF924
		public unsafe FColor C_BrushShape
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_BrushShape);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_C_BrushShape) = value;
			}
		}

		// Token: 0x170022E1 RID: 8929
		// (get) Token: 0x060091FA RID: 37370 RVA: 0x000D1739 File Offset: 0x000CF939
		// (set) Token: 0x060091FB RID: 37371 RVA: 0x000D1749 File Offset: 0x000CF949
		public unsafe float StreamingDistanceFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_StreamingDistanceFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_StreamingDistanceFactor) = value;
			}
		}

		// Token: 0x170022E2 RID: 8930
		// (get) Token: 0x060091FC RID: 37372 RVA: 0x000D175C File Offset: 0x000CF95C
		// (set) Token: 0x060091FD RID: 37373 RVA: 0x000D1795 File Offset: 0x000CF995
		public FDirectoryPath GameScreenshotSaveDirectory
		{
			get
			{
				base.FastCheckIsValid();
				FDirectoryPath result;
				if ((result = this._GameScreenshotSaveDirectory) == null)
				{
					result = (this._GameScreenshotSaveDirectory = new FDirectoryPath(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_GameScreenshotSaveDirectory, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDirectoryPath.StaticStruct(), base.NativePtr + (IntPtr)UEngine.__PropertyOffset_GameScreenshotSaveDirectory, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170022E3 RID: 8931
		// (get) Token: 0x060091FE RID: 37374 RVA: 0x000D17B6 File Offset: 0x000CF9B6
		// (set) Token: 0x060091FF RID: 37375 RVA: 0x000D17C6 File Offset: 0x000CF9C6
		public unsafe ETransitionType TransitionType
		{
			get
			{
				return (ETransitionType)(*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_TransitionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_TransitionType) = (byte)value;
			}
		}

		// Token: 0x170022E4 RID: 8932
		// (get) Token: 0x06009200 RID: 37376 RVA: 0x000D17D7 File Offset: 0x000CF9D7
		// (set) Token: 0x06009201 RID: 37377 RVA: 0x000D17EB File Offset: 0x000CF9EB
		public unsafe string TransitionDescription
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_TransitionDescription)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_TransitionDescription)), value);
			}
		}

		// Token: 0x170022E5 RID: 8933
		// (get) Token: 0x06009202 RID: 37378 RVA: 0x000D1800 File Offset: 0x000CFA00
		// (set) Token: 0x06009203 RID: 37379 RVA: 0x000D1814 File Offset: 0x000CFA14
		public unsafe string TransitionGameMode
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_TransitionGameMode)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_TransitionGameMode)), value);
			}
		}

		// Token: 0x170022E6 RID: 8934
		// (get) Token: 0x06009204 RID: 37380 RVA: 0x000D1829 File Offset: 0x000CFA29
		// (set) Token: 0x06009205 RID: 37381 RVA: 0x000D1842 File Offset: 0x000CFA42
		public unsafe bool bAllowMatureLanguage
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bAllowMatureLanguage) & UEngine.__PropertyMask_bAllowMatureLanguage) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEngine.__PropertyOffset_bAllowMatureLanguage) = ((*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bAllowMatureLanguage) & ~UEngine.__PropertyMask_bAllowMatureLanguage) | (value ? UEngine.__PropertyMask_bAllowMatureLanguage : 0));
			}
		}

		// Token: 0x170022E7 RID: 8935
		// (get) Token: 0x06009206 RID: 37382 RVA: 0x000D1872 File Offset: 0x000CFA72
		// (set) Token: 0x06009207 RID: 37383 RVA: 0x000D1882 File Offset: 0x000CFA82
		public unsafe float CameraRotationThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_CameraRotationThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_CameraRotationThreshold) = value;
			}
		}

		// Token: 0x170022E8 RID: 8936
		// (get) Token: 0x06009208 RID: 37384 RVA: 0x000D1893 File Offset: 0x000CFA93
		// (set) Token: 0x06009209 RID: 37385 RVA: 0x000D18A3 File Offset: 0x000CFAA3
		public unsafe float CameraTranslationThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_CameraTranslationThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_CameraTranslationThreshold) = value;
			}
		}

		// Token: 0x170022E9 RID: 8937
		// (get) Token: 0x0600920A RID: 37386 RVA: 0x000D18B4 File Offset: 0x000CFAB4
		// (set) Token: 0x0600920B RID: 37387 RVA: 0x000D18C4 File Offset: 0x000CFAC4
		public unsafe float PrimitiveProbablyVisibleTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_PrimitiveProbablyVisibleTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_PrimitiveProbablyVisibleTime) = value;
			}
		}

		// Token: 0x170022EA RID: 8938
		// (get) Token: 0x0600920C RID: 37388 RVA: 0x000D18D5 File Offset: 0x000CFAD5
		// (set) Token: 0x0600920D RID: 37389 RVA: 0x000D18E5 File Offset: 0x000CFAE5
		public unsafe float MaxOcclusionPixelsFraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MaxOcclusionPixelsFraction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MaxOcclusionPixelsFraction) = value;
			}
		}

		// Token: 0x170022EB RID: 8939
		// (get) Token: 0x0600920E RID: 37390 RVA: 0x000D18F6 File Offset: 0x000CFAF6
		// (set) Token: 0x0600920F RID: 37391 RVA: 0x000D190F File Offset: 0x000CFB0F
		public unsafe bool bPauseOnLossOfFocus
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bPauseOnLossOfFocus) & UEngine.__PropertyMask_bPauseOnLossOfFocus) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEngine.__PropertyOffset_bPauseOnLossOfFocus) = ((*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bPauseOnLossOfFocus) & ~UEngine.__PropertyMask_bPauseOnLossOfFocus) | (value ? UEngine.__PropertyMask_bPauseOnLossOfFocus : 0));
			}
		}

		// Token: 0x170022EC RID: 8940
		// (get) Token: 0x06009210 RID: 37392 RVA: 0x000D193F File Offset: 0x000CFB3F
		// (set) Token: 0x06009211 RID: 37393 RVA: 0x000D194F File Offset: 0x000CFB4F
		public unsafe int MaxParticleResize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MaxParticleResize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MaxParticleResize) = value;
			}
		}

		// Token: 0x170022ED RID: 8941
		// (get) Token: 0x06009212 RID: 37394 RVA: 0x000D1960 File Offset: 0x000CFB60
		// (set) Token: 0x06009213 RID: 37395 RVA: 0x000D1970 File Offset: 0x000CFB70
		public unsafe int MaxParticleResizeWarn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MaxParticleResizeWarn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MaxParticleResizeWarn) = value;
			}
		}

		// Token: 0x170022EE RID: 8942
		// (get) Token: 0x06009214 RID: 37396 RVA: 0x000D1984 File Offset: 0x000CFB84
		// (set) Token: 0x06009215 RID: 37397 RVA: 0x000D19BD File Offset: 0x000CFBBD
		public TArray<FDropNoteInfo> PendingDroppedNotes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FDropNoteInfo> result;
				if ((result = this._PendingDroppedNotes) == null)
				{
					result = (this._PendingDroppedNotes = new TArray<FDropNoteInfo>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_PendingDroppedNotes, this));
				}
				return result;
			}
			set
			{
				this.PendingDroppedNotes.CopyAssign(value);
			}
		}

		// Token: 0x170022EF RID: 8943
		// (get) Token: 0x06009216 RID: 37398 RVA: 0x000D19CB File Offset: 0x000CFBCB
		// (set) Token: 0x06009217 RID: 37399 RVA: 0x000D19DB File Offset: 0x000CFBDB
		public unsafe float NetClientTicksPerSecond
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_NetClientTicksPerSecond);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_NetClientTicksPerSecond) = value;
			}
		}

		// Token: 0x170022F0 RID: 8944
		// (get) Token: 0x06009218 RID: 37400 RVA: 0x000D19EC File Offset: 0x000CFBEC
		// (set) Token: 0x06009219 RID: 37401 RVA: 0x000D19FC File Offset: 0x000CFBFC
		public unsafe float DisplayGamma
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DisplayGamma);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DisplayGamma) = value;
			}
		}

		// Token: 0x170022F1 RID: 8945
		// (get) Token: 0x0600921A RID: 37402 RVA: 0x000D1A0D File Offset: 0x000CFC0D
		// (set) Token: 0x0600921B RID: 37403 RVA: 0x000D1A1D File Offset: 0x000CFC1D
		public unsafe float MinDesiredFrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MinDesiredFrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_MinDesiredFrameRate) = value;
			}
		}

		// Token: 0x170022F2 RID: 8946
		// (get) Token: 0x0600921C RID: 37404 RVA: 0x000D1A2E File Offset: 0x000CFC2E
		// (set) Token: 0x0600921D RID: 37405 RVA: 0x000D1A42 File Offset: 0x000CFC42
		public unsafe FLinearColor DefaultSelectedMaterialColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DefaultSelectedMaterialColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_DefaultSelectedMaterialColor) = value;
			}
		}

		// Token: 0x170022F3 RID: 8947
		// (get) Token: 0x0600921E RID: 37406 RVA: 0x000D1A57 File Offset: 0x000CFC57
		// (set) Token: 0x0600921F RID: 37407 RVA: 0x000D1A6B File Offset: 0x000CFC6B
		public unsafe FLinearColor SelectedMaterialColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_SelectedMaterialColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_SelectedMaterialColor) = value;
			}
		}

		// Token: 0x170022F4 RID: 8948
		// (get) Token: 0x06009220 RID: 37408 RVA: 0x000D1A80 File Offset: 0x000CFC80
		// (set) Token: 0x06009221 RID: 37409 RVA: 0x000D1A94 File Offset: 0x000CFC94
		public unsafe FLinearColor SelectionOutlineColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_SelectionOutlineColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_SelectionOutlineColor) = value;
			}
		}

		// Token: 0x170022F5 RID: 8949
		// (get) Token: 0x06009222 RID: 37410 RVA: 0x000D1AA9 File Offset: 0x000CFCA9
		// (set) Token: 0x06009223 RID: 37411 RVA: 0x000D1ABD File Offset: 0x000CFCBD
		public unsafe FLinearColor SubduedSelectionOutlineColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_SubduedSelectionOutlineColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_SubduedSelectionOutlineColor) = value;
			}
		}

		// Token: 0x170022F6 RID: 8950
		// (get) Token: 0x06009224 RID: 37412 RVA: 0x000D1AD2 File Offset: 0x000CFCD2
		// (set) Token: 0x06009225 RID: 37413 RVA: 0x000D1AE6 File Offset: 0x000CFCE6
		public unsafe FLinearColor SelectedMaterialColorOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_SelectedMaterialColorOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_SelectedMaterialColorOverride) = value;
			}
		}

		// Token: 0x170022F7 RID: 8951
		// (get) Token: 0x06009226 RID: 37414 RVA: 0x000D1AFB File Offset: 0x000CFCFB
		// (set) Token: 0x06009227 RID: 37415 RVA: 0x000D1B0B File Offset: 0x000CFD0B
		public unsafe bool bIsOverridingSelectedColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bIsOverridingSelectedColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bIsOverridingSelectedColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170022F8 RID: 8952
		// (get) Token: 0x06009228 RID: 37416 RVA: 0x000D1B1C File Offset: 0x000CFD1C
		// (set) Token: 0x06009229 RID: 37417 RVA: 0x000D1B35 File Offset: 0x000CFD35
		public unsafe bool bEnableOnScreenDebugMessages
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bEnableOnScreenDebugMessages) & UEngine.__PropertyMask_bEnableOnScreenDebugMessages) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEngine.__PropertyOffset_bEnableOnScreenDebugMessages) = ((*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bEnableOnScreenDebugMessages) & ~UEngine.__PropertyMask_bEnableOnScreenDebugMessages) | (value ? UEngine.__PropertyMask_bEnableOnScreenDebugMessages : 0));
			}
		}

		// Token: 0x170022F9 RID: 8953
		// (get) Token: 0x0600922A RID: 37418 RVA: 0x000D1B65 File Offset: 0x000CFD65
		// (set) Token: 0x0600922B RID: 37419 RVA: 0x000D1B7E File Offset: 0x000CFD7E
		public unsafe bool bEnableOnScreenDebugMessagesDisplay
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bEnableOnScreenDebugMessagesDisplay) & UEngine.__PropertyMask_bEnableOnScreenDebugMessagesDisplay) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEngine.__PropertyOffset_bEnableOnScreenDebugMessagesDisplay) = ((*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bEnableOnScreenDebugMessagesDisplay) & ~UEngine.__PropertyMask_bEnableOnScreenDebugMessagesDisplay) | (value ? UEngine.__PropertyMask_bEnableOnScreenDebugMessagesDisplay : 0));
			}
		}

		// Token: 0x170022FA RID: 8954
		// (get) Token: 0x0600922C RID: 37420 RVA: 0x000D1BAE File Offset: 0x000CFDAE
		// (set) Token: 0x0600922D RID: 37421 RVA: 0x000D1BC7 File Offset: 0x000CFDC7
		public unsafe bool bSuppressMapWarnings
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bSuppressMapWarnings) & UEngine.__PropertyMask_bSuppressMapWarnings) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEngine.__PropertyOffset_bSuppressMapWarnings) = ((*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bSuppressMapWarnings) & ~UEngine.__PropertyMask_bSuppressMapWarnings) | (value ? UEngine.__PropertyMask_bSuppressMapWarnings : 0));
			}
		}

		// Token: 0x170022FB RID: 8955
		// (get) Token: 0x0600922E RID: 37422 RVA: 0x000D1BF7 File Offset: 0x000CFDF7
		// (set) Token: 0x0600922F RID: 37423 RVA: 0x000D1C10 File Offset: 0x000CFE10
		public unsafe bool bDisableAILogging
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bDisableAILogging) & UEngine.__PropertyMask_bDisableAILogging) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEngine.__PropertyOffset_bDisableAILogging) = ((*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bDisableAILogging) & ~UEngine.__PropertyMask_bDisableAILogging) | (value ? UEngine.__PropertyMask_bDisableAILogging : 0));
			}
		}

		// Token: 0x170022FC RID: 8956
		// (get) Token: 0x06009230 RID: 37424 RVA: 0x000D1C40 File Offset: 0x000CFE40
		// (set) Token: 0x06009231 RID: 37425 RVA: 0x000D1C50 File Offset: 0x000CFE50
		public unsafe uint bEnableVisualLogRecordingOnStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bEnableVisualLogRecordingOnStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bEnableVisualLogRecordingOnStart) = (int)value;
			}
		}

		// Token: 0x170022FD RID: 8957
		// (get) Token: 0x06009232 RID: 37426 RVA: 0x000D1C61 File Offset: 0x000CFE61
		// (set) Token: 0x06009233 RID: 37427 RVA: 0x000D1C71 File Offset: 0x000CFE71
		public unsafe int ScreenSaverInhibitorSemaphore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_ScreenSaverInhibitorSemaphore);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_ScreenSaverInhibitorSemaphore) = value;
			}
		}

		// Token: 0x170022FE RID: 8958
		// (get) Token: 0x06009234 RID: 37428 RVA: 0x000D1C82 File Offset: 0x000CFE82
		// (set) Token: 0x06009235 RID: 37429 RVA: 0x000D1C9B File Offset: 0x000CFE9B
		public unsafe bool bLockReadOnlyLevels
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bLockReadOnlyLevels) & UEngine.__PropertyMask_bLockReadOnlyLevels) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEngine.__PropertyOffset_bLockReadOnlyLevels) = ((*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bLockReadOnlyLevels) & ~UEngine.__PropertyMask_bLockReadOnlyLevels) | (value ? UEngine.__PropertyMask_bLockReadOnlyLevels : 0));
			}
		}

		// Token: 0x170022FF RID: 8959
		// (get) Token: 0x06009236 RID: 37430 RVA: 0x000D1CCB File Offset: 0x000CFECB
		// (set) Token: 0x06009237 RID: 37431 RVA: 0x000D1CDF File Offset: 0x000CFEDF
		public unsafe string ParticleEventManagerClassPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_ParticleEventManagerClassPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngine.__PropertyOffset_ParticleEventManagerClassPath)), value);
			}
		}

		// Token: 0x17002300 RID: 8960
		// (get) Token: 0x06009238 RID: 37432 RVA: 0x000D1CF4 File Offset: 0x000CFEF4
		// (set) Token: 0x06009239 RID: 37433 RVA: 0x000D1D04 File Offset: 0x000CFF04
		public unsafe float SelectionHighlightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_SelectionHighlightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_SelectionHighlightIntensity) = value;
			}
		}

		// Token: 0x17002301 RID: 8961
		// (get) Token: 0x0600923A RID: 37434 RVA: 0x000D1D15 File Offset: 0x000CFF15
		// (set) Token: 0x0600923B RID: 37435 RVA: 0x000D1D25 File Offset: 0x000CFF25
		public unsafe float BSPSelectionHighlightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_BSPSelectionHighlightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_BSPSelectionHighlightIntensity) = value;
			}
		}

		// Token: 0x17002302 RID: 8962
		// (get) Token: 0x0600923C RID: 37436 RVA: 0x000D1D36 File Offset: 0x000CFF36
		// (set) Token: 0x0600923D RID: 37437 RVA: 0x000D1D46 File Offset: 0x000CFF46
		public unsafe float SelectionHighlightIntensityBillboards
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_SelectionHighlightIntensityBillboards);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_SelectionHighlightIntensityBillboards) = value;
			}
		}

		// Token: 0x17002303 RID: 8963
		// (get) Token: 0x0600923E RID: 37438 RVA: 0x000D1D58 File Offset: 0x000CFF58
		// (set) Token: 0x0600923F RID: 37439 RVA: 0x000D1D91 File Offset: 0x000CFF91
		public TArray<FNetDriverDefinition> NetDriverDefinitions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNetDriverDefinition> result;
				if ((result = this._NetDriverDefinitions) == null)
				{
					result = (this._NetDriverDefinitions = new TArray<FNetDriverDefinition>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_NetDriverDefinitions, this));
				}
				return result;
			}
			set
			{
				this.NetDriverDefinitions.CopyAssign(value);
			}
		}

		// Token: 0x17002304 RID: 8964
		// (get) Token: 0x06009240 RID: 37440 RVA: 0x000D1DA0 File Offset: 0x000CFFA0
		// (set) Token: 0x06009241 RID: 37441 RVA: 0x000D1DD9 File Offset: 0x000CFFD9
		public TArray<string> ServerActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ServerActors) == null)
				{
					result = (this._ServerActors = new TArray<string>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_ServerActors, this));
				}
				return result;
			}
			set
			{
				this.ServerActors.CopyAssign(value);
			}
		}

		// Token: 0x17002305 RID: 8965
		// (get) Token: 0x06009242 RID: 37442 RVA: 0x000D1DE8 File Offset: 0x000CFFE8
		// (set) Token: 0x06009243 RID: 37443 RVA: 0x000D1E21 File Offset: 0x000D0021
		public TArray<string> RuntimeServerActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._RuntimeServerActors) == null)
				{
					result = (this._RuntimeServerActors = new TArray<string>(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_RuntimeServerActors, this));
				}
				return result;
			}
			set
			{
				this.RuntimeServerActors.CopyAssign(value);
			}
		}

		// Token: 0x17002306 RID: 8966
		// (get) Token: 0x06009244 RID: 37444 RVA: 0x000D1E2F File Offset: 0x000D002F
		// (set) Token: 0x06009245 RID: 37445 RVA: 0x000D1E3F File Offset: 0x000D003F
		public unsafe float NetErrorLogInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_NetErrorLogInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_NetErrorLogInterval) = value;
			}
		}

		// Token: 0x17002307 RID: 8967
		// (get) Token: 0x06009246 RID: 37446 RVA: 0x000D1E50 File Offset: 0x000D0050
		// (set) Token: 0x06009247 RID: 37447 RVA: 0x000D1E69 File Offset: 0x000D0069
		public unsafe bool bStartedLoadMapMovie
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bStartedLoadMapMovie) & UEngine.__PropertyMask_bStartedLoadMapMovie) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEngine.__PropertyOffset_bStartedLoadMapMovie) = ((*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_bStartedLoadMapMovie) & ~UEngine.__PropertyMask_bStartedLoadMapMovie) | (value ? UEngine.__PropertyMask_bStartedLoadMapMovie : 0));
			}
		}

		// Token: 0x17002308 RID: 8968
		// (get) Token: 0x06009248 RID: 37448 RVA: 0x000D1E99 File Offset: 0x000D0099
		// (set) Token: 0x06009249 RID: 37449 RVA: 0x000D1EA9 File Offset: 0x000D00A9
		public unsafe int NextWorldContextHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_NextWorldContextHandle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEngine.__PropertyOffset_NextWorldContextHandle) = value;
			}
		}

		// Token: 0x0600924A RID: 37450 RVA: 0x000D1EBA File Offset: 0x000D00BA
		static UEngine()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Engine");
		}

		// Token: 0x0600924B RID: 37451 RVA: 0x000D1EC8 File Offset: 0x000D00C8
		protected UEngine() : this(BuiltinUtils.AllocNativeUObject(UEngine.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600924C RID: 37452 RVA: 0x000D1EF0 File Offset: 0x000D00F0
		protected UEngine(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004B7C RID: 19324
		public new const string __ObjectPath = "/Script/Engine.Engine";

		// Token: 0x04004B7D RID: 19325
		private static IntPtr _ClassPtr;

		// Token: 0x04004B7E RID: 19326
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004B7F RID: 19327
		internal static int __PropertyOffset_TinyFont;

		// Token: 0x04004B80 RID: 19328
		internal static int __PropertyOffset_TinyFontName;

		// Token: 0x04004B81 RID: 19329
		[Nullable(2)]
		private FSoftObjectPath _TinyFontName;

		// Token: 0x04004B82 RID: 19330
		internal static int __PropertyOffset_SmallFont;

		// Token: 0x04004B83 RID: 19331
		internal static int __PropertyOffset_SmallFontName;

		// Token: 0x04004B84 RID: 19332
		[Nullable(2)]
		private FSoftObjectPath _SmallFontName;

		// Token: 0x04004B85 RID: 19333
		internal static int __PropertyOffset_MediumFont;

		// Token: 0x04004B86 RID: 19334
		internal static int __PropertyOffset_MediumFontName;

		// Token: 0x04004B87 RID: 19335
		[Nullable(2)]
		private FSoftObjectPath _MediumFontName;

		// Token: 0x04004B88 RID: 19336
		internal static int __PropertyOffset_LargeFont;

		// Token: 0x04004B89 RID: 19337
		internal static int __PropertyOffset_LargeFontName;

		// Token: 0x04004B8A RID: 19338
		[Nullable(2)]
		private FSoftObjectPath _LargeFontName;

		// Token: 0x04004B8B RID: 19339
		internal static int __PropertyOffset_SubtitleFont;

		// Token: 0x04004B8C RID: 19340
		internal static int __PropertyOffset_SubtitleFontName;

		// Token: 0x04004B8D RID: 19341
		[Nullable(2)]
		private FSoftObjectPath _SubtitleFontName;

		// Token: 0x04004B8E RID: 19342
		internal static int __PropertyOffset_AdditionalFonts;

		// Token: 0x04004B8F RID: 19343
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UFont> _AdditionalFonts;

		// Token: 0x04004B90 RID: 19344
		internal static int __PropertyOffset_AdditionalFontNames;

		// Token: 0x04004B91 RID: 19345
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AdditionalFontNames;

		// Token: 0x04004B92 RID: 19346
		internal static int __PropertyOffset_ConsoleClass;

		// Token: 0x04004B93 RID: 19347
		internal static int __PropertyOffset_ConsoleClassName;

		// Token: 0x04004B94 RID: 19348
		[Nullable(2)]
		private FSoftClassPath _ConsoleClassName;

		// Token: 0x04004B95 RID: 19349
		internal static int __PropertyOffset_GameViewportClientClass;

		// Token: 0x04004B96 RID: 19350
		internal static int __PropertyOffset_GameViewportClientClassName;

		// Token: 0x04004B97 RID: 19351
		[Nullable(2)]
		private FSoftClassPath _GameViewportClientClassName;

		// Token: 0x04004B98 RID: 19352
		internal static int __PropertyOffset_LocalPlayerClass;

		// Token: 0x04004B99 RID: 19353
		internal static int __PropertyOffset_LocalPlayerClassName;

		// Token: 0x04004B9A RID: 19354
		[Nullable(2)]
		private FSoftClassPath _LocalPlayerClassName;

		// Token: 0x04004B9B RID: 19355
		internal static int __PropertyOffset_WorldSettingsClass;

		// Token: 0x04004B9C RID: 19356
		internal static int __PropertyOffset_WorldSettingsClassName;

		// Token: 0x04004B9D RID: 19357
		[Nullable(2)]
		private FSoftClassPath _WorldSettingsClassName;

		// Token: 0x04004B9E RID: 19358
		internal static int __PropertyOffset_NavigationSystemClassName;

		// Token: 0x04004B9F RID: 19359
		[Nullable(2)]
		private FSoftClassPath _NavigationSystemClassName;

		// Token: 0x04004BA0 RID: 19360
		internal static int __PropertyOffset_NavigationSystemClass;

		// Token: 0x04004BA1 RID: 19361
		internal static int __PropertyOffset_NavigationSystemConfigClassName;

		// Token: 0x04004BA2 RID: 19362
		[Nullable(2)]
		private FSoftClassPath _NavigationSystemConfigClassName;

		// Token: 0x04004BA3 RID: 19363
		internal static int __PropertyOffset_NavigationSystemConfigClass;

		// Token: 0x04004BA4 RID: 19364
		internal static int __PropertyOffset_AvoidanceManagerClassName;

		// Token: 0x04004BA5 RID: 19365
		[Nullable(2)]
		private FSoftClassPath _AvoidanceManagerClassName;

		// Token: 0x04004BA6 RID: 19366
		internal static int __PropertyOffset_AvoidanceManagerClass;

		// Token: 0x04004BA7 RID: 19367
		internal static int __PropertyOffset_AIControllerClassName;

		// Token: 0x04004BA8 RID: 19368
		[Nullable(2)]
		private FSoftClassPath _AIControllerClassName;

		// Token: 0x04004BA9 RID: 19369
		internal static int __PropertyOffset_PhysicsCollisionHandlerClass;

		// Token: 0x04004BAA RID: 19370
		internal static int __PropertyOffset_PhysicsCollisionHandlerClassName;

		// Token: 0x04004BAB RID: 19371
		[Nullable(2)]
		private FSoftClassPath _PhysicsCollisionHandlerClassName;

		// Token: 0x04004BAC RID: 19372
		internal static int __PropertyOffset_GameUserSettingsClassName;

		// Token: 0x04004BAD RID: 19373
		[Nullable(2)]
		private FSoftClassPath _GameUserSettingsClassName;

		// Token: 0x04004BAE RID: 19374
		internal static int __PropertyOffset_GameUserSettingsClass;

		// Token: 0x04004BAF RID: 19375
		internal static int __PropertyOffset_GameUserSettings;

		// Token: 0x04004BB0 RID: 19376
		internal static int __PropertyOffset_LevelScriptActorClass;

		// Token: 0x04004BB1 RID: 19377
		internal static int __PropertyOffset_LevelScriptActorClassName;

		// Token: 0x04004BB2 RID: 19378
		[Nullable(2)]
		private FSoftClassPath _LevelScriptActorClassName;

		// Token: 0x04004BB3 RID: 19379
		internal static int __PropertyOffset_DefaultBlueprintBaseClassName;

		// Token: 0x04004BB4 RID: 19380
		[Nullable(2)]
		private FSoftClassPath _DefaultBlueprintBaseClassName;

		// Token: 0x04004BB5 RID: 19381
		internal static int __PropertyOffset_GameSingletonClassName;

		// Token: 0x04004BB6 RID: 19382
		[Nullable(2)]
		private FSoftClassPath _GameSingletonClassName;

		// Token: 0x04004BB7 RID: 19383
		internal static int __PropertyOffset_GameSingleton;

		// Token: 0x04004BB8 RID: 19384
		internal static int __PropertyOffset_AssetManagerClassName;

		// Token: 0x04004BB9 RID: 19385
		[Nullable(2)]
		private FSoftClassPath _AssetManagerClassName;

		// Token: 0x04004BBA RID: 19386
		internal static int __PropertyOffset_AssetManager;

		// Token: 0x04004BBB RID: 19387
		internal static int __PropertyOffset_DefaultTexture;

		// Token: 0x04004BBC RID: 19388
		internal static int __PropertyOffset_DefaultTextureName;

		// Token: 0x04004BBD RID: 19389
		[Nullable(2)]
		private FSoftObjectPath _DefaultTextureName;

		// Token: 0x04004BBE RID: 19390
		internal static int __PropertyOffset_DefaultDiffuseTexture;

		// Token: 0x04004BBF RID: 19391
		internal static int __PropertyOffset_DefaultDiffuseTextureName;

		// Token: 0x04004BC0 RID: 19392
		[Nullable(2)]
		private FSoftObjectPath _DefaultDiffuseTextureName;

		// Token: 0x04004BC1 RID: 19393
		internal static int __PropertyOffset_DefaultBSPVertexTexture;

		// Token: 0x04004BC2 RID: 19394
		internal static int __PropertyOffset_DefaultBSPVertexTextureName;

		// Token: 0x04004BC3 RID: 19395
		[Nullable(2)]
		private FSoftObjectPath _DefaultBSPVertexTextureName;

		// Token: 0x04004BC4 RID: 19396
		internal static int __PropertyOffset_HighFrequencyNoiseTexture;

		// Token: 0x04004BC5 RID: 19397
		internal static int __PropertyOffset_HighFrequencyNoiseTextureName;

		// Token: 0x04004BC6 RID: 19398
		[Nullable(2)]
		private FSoftObjectPath _HighFrequencyNoiseTextureName;

		// Token: 0x04004BC7 RID: 19399
		internal static int __PropertyOffset_DefaultBokehTexture;

		// Token: 0x04004BC8 RID: 19400
		internal static int __PropertyOffset_DefaultBokehTextureName;

		// Token: 0x04004BC9 RID: 19401
		[Nullable(2)]
		private FSoftObjectPath _DefaultBokehTextureName;

		// Token: 0x04004BCA RID: 19402
		internal static int __PropertyOffset_DefaultBloomKernelTexture;

		// Token: 0x04004BCB RID: 19403
		internal static int __PropertyOffset_DefaultBloomKernelTextureName;

		// Token: 0x04004BCC RID: 19404
		[Nullable(2)]
		private FSoftObjectPath _DefaultBloomKernelTextureName;

		// Token: 0x04004BCD RID: 19405
		internal static int __PropertyOffset_WireframeMaterial;

		// Token: 0x04004BCE RID: 19406
		internal static int __PropertyOffset_WireframeMaterialName;

		// Token: 0x04004BCF RID: 19407
		internal static int __PropertyOffset_VisGeoNormalMaterial;

		// Token: 0x04004BD0 RID: 19408
		internal static int __PropertyOffset_VisGeoNormalMaterialName;

		// Token: 0x04004BD1 RID: 19409
		internal static int __PropertyOffset_DebugMeshMaterial;

		// Token: 0x04004BD2 RID: 19410
		internal static int __PropertyOffset_DebugMeshMaterialName;

		// Token: 0x04004BD3 RID: 19411
		[Nullable(2)]
		private FSoftObjectPath _DebugMeshMaterialName;

		// Token: 0x04004BD4 RID: 19412
		internal static int __PropertyOffset_DebugCanCharacterStandUpOnMaterial;

		// Token: 0x04004BD5 RID: 19413
		internal static int __PropertyOffset_DebugCanCharacterStandUpOnName;

		// Token: 0x04004BD6 RID: 19414
		[Nullable(2)]
		private FSoftObjectPath _DebugCanCharacterStandUpOnName;

		// Token: 0x04004BD7 RID: 19415
		internal static int __PropertyOffset_EmissiveMeshMaterial;

		// Token: 0x04004BD8 RID: 19416
		internal static int __PropertyOffset_EmissiveMeshMaterialName;

		// Token: 0x04004BD9 RID: 19417
		[Nullable(2)]
		private FSoftObjectPath _EmissiveMeshMaterialName;

		// Token: 0x04004BDA RID: 19418
		internal static int __PropertyOffset_LevelColorationLitMaterial;

		// Token: 0x04004BDB RID: 19419
		internal static int __PropertyOffset_LevelColorationLitMaterialName;

		// Token: 0x04004BDC RID: 19420
		internal static int __PropertyOffset_LevelColorationUnlitMaterial;

		// Token: 0x04004BDD RID: 19421
		internal static int __PropertyOffset_LevelColorationUnlitMaterialName;

		// Token: 0x04004BDE RID: 19422
		internal static int __PropertyOffset_LightingTexelDensityMaterial;

		// Token: 0x04004BDF RID: 19423
		internal static int __PropertyOffset_LightingTexelDensityName;

		// Token: 0x04004BE0 RID: 19424
		internal static int __PropertyOffset_ShadedLevelColorationLitMaterial;

		// Token: 0x04004BE1 RID: 19425
		internal static int __PropertyOffset_ShadedLevelColorationLitMaterialName;

		// Token: 0x04004BE2 RID: 19426
		internal static int __PropertyOffset_ShadedLevelColorationUnlitMaterial;

		// Token: 0x04004BE3 RID: 19427
		internal static int __PropertyOffset_ShadedLevelColorationUnlitMaterialName;

		// Token: 0x04004BE4 RID: 19428
		internal static int __PropertyOffset_Generate2DMapParentMaterialMap;

		// Token: 0x04004BE5 RID: 19429
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UMaterial> _Generate2DMapParentMaterialMap;

		// Token: 0x04004BE6 RID: 19430
		internal static int __PropertyOffset_Generate2DMapNameTagMap;

		// Token: 0x04004BE7 RID: 19431
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UMaterial> _Generate2DMapNameTagMap;

		// Token: 0x04004BE8 RID: 19432
		internal static int __PropertyOffset_Generate2DMapMeshPathMap;

		// Token: 0x04004BE9 RID: 19433
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UMaterial> _Generate2DMapMeshPathMap;

		// Token: 0x04004BEA RID: 19434
		internal static int __PropertyOffset_Kuro2DMapGenerateMatMapJson;

		// Token: 0x04004BEB RID: 19435
		[Nullable(2)]
		private FKuro2DMapGenerateMatMap _Kuro2DMapGenerateMatMapJson;

		// Token: 0x04004BEC RID: 19436
		internal static int __PropertyOffset_Generate2DMapLandMaterial;

		// Token: 0x04004BED RID: 19437
		internal static int __PropertyOffset_Generate2DMapLandMaterialName;

		// Token: 0x04004BEE RID: 19438
		internal static int __PropertyOffset_Generate2DMapBuildingMaterial;

		// Token: 0x04004BEF RID: 19439
		internal static int __PropertyOffset_Generate2DMapBuildingMaterialName;

		// Token: 0x04004BF0 RID: 19440
		internal static int __PropertyOffset_Generate2DMapWaterMaterial;

		// Token: 0x04004BF1 RID: 19441
		internal static int __PropertyOffset_Generate2DMapWaterMaterialName;

		// Token: 0x04004BF2 RID: 19442
		internal static int __PropertyOffset_Generate2DMapTreeMaterial;

		// Token: 0x04004BF3 RID: 19443
		internal static int __PropertyOffset_Generate2DMapTreeMaterialName;

		// Token: 0x04004BF4 RID: 19444
		internal static int __PropertyOffset_Generate2DMapNoneMaterial;

		// Token: 0x04004BF5 RID: 19445
		internal static int __PropertyOffset_Generate2DMapNoneMaterialName;

		// Token: 0x04004BF6 RID: 19446
		internal static int __PropertyOffset_Generate2DMapSpecil01Material;

		// Token: 0x04004BF7 RID: 19447
		internal static int __PropertyOffset_Generate2DMapSpecil01MaterialName;

		// Token: 0x04004BF8 RID: 19448
		internal static int __PropertyOffset_Generate2DMapSpecil02Material;

		// Token: 0x04004BF9 RID: 19449
		internal static int __PropertyOffset_Generate2DMapSpecil02MaterialName;

		// Token: 0x04004BFA RID: 19450
		internal static int __PropertyOffset_PSODebugFallbackMaterial;

		// Token: 0x04004BFB RID: 19451
		internal static int __PropertyOffset_PSODebugFallbackMaterialName;

		// Token: 0x04004BFC RID: 19452
		[Nullable(2)]
		private FSoftObjectPath _PSODebugFallbackMaterialName;

		// Token: 0x04004BFD RID: 19453
		internal static int __PropertyOffset_RemoveSurfaceMaterial;

		// Token: 0x04004BFE RID: 19454
		internal static int __PropertyOffset_RemoveSurfaceMaterialName;

		// Token: 0x04004BFF RID: 19455
		[Nullable(2)]
		private FSoftObjectPath _RemoveSurfaceMaterialName;

		// Token: 0x04004C00 RID: 19456
		internal static int __PropertyOffset_VertexColorMaterial;

		// Token: 0x04004C01 RID: 19457
		internal static int __PropertyOffset_VertexColorMaterialName;

		// Token: 0x04004C02 RID: 19458
		internal static int __PropertyOffset_VertexColorViewModeMaterial_ColorOnly;

		// Token: 0x04004C03 RID: 19459
		internal static int __PropertyOffset_VertexColorViewModeMaterialName_ColorOnly;

		// Token: 0x04004C04 RID: 19460
		internal static int __PropertyOffset_VertexColorViewModeMaterial_AlphaAsColor;

		// Token: 0x04004C05 RID: 19461
		internal static int __PropertyOffset_VertexColorViewModeMaterialName_AlphaAsColor;

		// Token: 0x04004C06 RID: 19462
		internal static int __PropertyOffset_VertexColorViewModeMaterial_RedOnly;

		// Token: 0x04004C07 RID: 19463
		internal static int __PropertyOffset_VertexColorViewModeMaterialName_RedOnly;

		// Token: 0x04004C08 RID: 19464
		internal static int __PropertyOffset_VertexColorViewModeMaterial_GreenOnly;

		// Token: 0x04004C09 RID: 19465
		internal static int __PropertyOffset_VertexColorViewModeMaterialName_GreenOnly;

		// Token: 0x04004C0A RID: 19466
		internal static int __PropertyOffset_VertexColorViewModeMaterial_BlueOnly;

		// Token: 0x04004C0B RID: 19467
		internal static int __PropertyOffset_VertexColorViewModeMaterialName_BlueOnly;

		// Token: 0x04004C0C RID: 19468
		internal static int __PropertyOffset_VertexColorViewModeMaterial_FlowArrow;

		// Token: 0x04004C0D RID: 19469
		internal static int __PropertyOffset_VertexColorViewModeMaterialName_FlowArrow;

		// Token: 0x04004C0E RID: 19470
		internal static int __PropertyOffset_VertexColorViewModeMaterial_FlowWater;

		// Token: 0x04004C0F RID: 19471
		internal static int __PropertyOffset_VertexColorViewModeMaterialName_FlowWater;

		// Token: 0x04004C10 RID: 19472
		internal static int __PropertyOffset_DebugEditorMaterialName;

		// Token: 0x04004C11 RID: 19473
		[Nullable(2)]
		private FSoftObjectPath _DebugEditorMaterialName;

		// Token: 0x04004C12 RID: 19474
		internal static int __PropertyOffset_ConstraintLimitMaterial;

		// Token: 0x04004C13 RID: 19475
		internal static int __PropertyOffset_ConstraintLimitMaterialX;

		// Token: 0x04004C14 RID: 19476
		internal static int __PropertyOffset_ConstraintLimitMaterialXAxis;

		// Token: 0x04004C15 RID: 19477
		internal static int __PropertyOffset_ConstraintLimitMaterialY;

		// Token: 0x04004C16 RID: 19478
		internal static int __PropertyOffset_ConstraintLimitMaterialYAxis;

		// Token: 0x04004C17 RID: 19479
		internal static int __PropertyOffset_ConstraintLimitMaterialZ;

		// Token: 0x04004C18 RID: 19480
		internal static int __PropertyOffset_ConstraintLimitMaterialZAxis;

		// Token: 0x04004C19 RID: 19481
		internal static int __PropertyOffset_ConstraintLimitMaterialPrismatic;

		// Token: 0x04004C1A RID: 19482
		internal static int __PropertyOffset_InvalidLightmapSettingsMaterial;

		// Token: 0x04004C1B RID: 19483
		internal static int __PropertyOffset_InvalidLightmapSettingsMaterialName;

		// Token: 0x04004C1C RID: 19484
		[Nullable(2)]
		private FSoftObjectPath _InvalidLightmapSettingsMaterialName;

		// Token: 0x04004C1D RID: 19485
		internal static int __PropertyOffset_PreviewShadowsIndicatorMaterial;

		// Token: 0x04004C1E RID: 19486
		internal static int __PropertyOffset_PreviewShadowsIndicatorMaterialName;

		// Token: 0x04004C1F RID: 19487
		[Nullable(2)]
		private FSoftObjectPath _PreviewShadowsIndicatorMaterialName;

		// Token: 0x04004C20 RID: 19488
		internal static int __PropertyOffset_ArrowMaterial;

		// Token: 0x04004C21 RID: 19489
		internal static int __PropertyOffset_ArrowMaterialYellow;

		// Token: 0x04004C22 RID: 19490
		internal static int __PropertyOffset_ArrowMaterialName;

		// Token: 0x04004C23 RID: 19491
		[Nullable(2)]
		private FSoftObjectPath _ArrowMaterialName;

		// Token: 0x04004C24 RID: 19492
		internal static int __PropertyOffset_LightingOnlyBrightness;

		// Token: 0x04004C25 RID: 19493
		internal static int __PropertyOffset_ShaderComplexityColors;

		// Token: 0x04004C26 RID: 19494
		[Nullable(2)]
		private TArray<FLinearColor> _ShaderComplexityColors;

		// Token: 0x04004C27 RID: 19495
		internal static int __PropertyOffset_QuadComplexityColors;

		// Token: 0x04004C28 RID: 19496
		[Nullable(2)]
		private TArray<FLinearColor> _QuadComplexityColors;

		// Token: 0x04004C29 RID: 19497
		internal static int __PropertyOffset_LightComplexityColors;

		// Token: 0x04004C2A RID: 19498
		[Nullable(2)]
		private TArray<FLinearColor> _LightComplexityColors;

		// Token: 0x04004C2B RID: 19499
		internal static int __PropertyOffset_StationaryLightOverlapColors;

		// Token: 0x04004C2C RID: 19500
		[Nullable(2)]
		private TArray<FLinearColor> _StationaryLightOverlapColors;

		// Token: 0x04004C2D RID: 19501
		internal static int __PropertyOffset_LODColorationColors;

		// Token: 0x04004C2E RID: 19502
		[Nullable(2)]
		private TArray<FLinearColor> _LODColorationColors;

		// Token: 0x04004C2F RID: 19503
		internal static int __PropertyOffset_HLODColorationColors;

		// Token: 0x04004C30 RID: 19504
		[Nullable(2)]
		private TArray<FLinearColor> _HLODColorationColors;

		// Token: 0x04004C31 RID: 19505
		internal static int __PropertyOffset_StreamingAccuracyColors;

		// Token: 0x04004C32 RID: 19506
		[Nullable(2)]
		private TArray<FLinearColor> _StreamingAccuracyColors;

		// Token: 0x04004C33 RID: 19507
		internal static int __PropertyOffset_MaxPixelShaderAdditiveComplexityCount;

		// Token: 0x04004C34 RID: 19508
		internal static int __PropertyOffset_MaxES3PixelShaderAdditiveComplexityCount;

		// Token: 0x04004C35 RID: 19509
		internal static int __PropertyOffset_MinLightMapDensity;

		// Token: 0x04004C36 RID: 19510
		internal static int __PropertyOffset_IdealLightMapDensity;

		// Token: 0x04004C37 RID: 19511
		internal static int __PropertyOffset_MaxLightMapDensity;

		// Token: 0x04004C38 RID: 19512
		internal static int __PropertyOffset_bRenderLightMapDensityGrayscale;

		// Token: 0x04004C39 RID: 19513
		internal static byte __PropertyMask_bRenderLightMapDensityGrayscale;

		// Token: 0x04004C3A RID: 19514
		internal static int __PropertyOffset_RenderLightMapDensityGrayscaleScale;

		// Token: 0x04004C3B RID: 19515
		internal static int __PropertyOffset_RenderLightMapDensityColorScale;

		// Token: 0x04004C3C RID: 19516
		internal static int __PropertyOffset_LightMapDensityVertexMappedColor;

		// Token: 0x04004C3D RID: 19517
		internal static int __PropertyOffset_LightMapDensitySelectedColor;

		// Token: 0x04004C3E RID: 19518
		internal static int __PropertyOffset_StatColorMappings;

		// Token: 0x04004C3F RID: 19519
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStatColorMapping> _StatColorMappings;

		// Token: 0x04004C40 RID: 19520
		internal static int __PropertyOffset_DefaultPhysMaterial;

		// Token: 0x04004C41 RID: 19521
		internal static int __PropertyOffset_DefaultPhysMaterialName;

		// Token: 0x04004C42 RID: 19522
		[Nullable(2)]
		private FSoftObjectPath _DefaultPhysMaterialName;

		// Token: 0x04004C43 RID: 19523
		internal static int __PropertyOffset_ActiveGameNameRedirects;

		// Token: 0x04004C44 RID: 19524
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameNameRedirect> _ActiveGameNameRedirects;

		// Token: 0x04004C45 RID: 19525
		internal static int __PropertyOffset_ActiveClassRedirects;

		// Token: 0x04004C46 RID: 19526
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FClassRedirect> _ActiveClassRedirects;

		// Token: 0x04004C47 RID: 19527
		internal static int __PropertyOffset_ActivePluginRedirects;

		// Token: 0x04004C48 RID: 19528
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPluginRedirect> _ActivePluginRedirects;

		// Token: 0x04004C49 RID: 19529
		internal static int __PropertyOffset_ActiveStructRedirects;

		// Token: 0x04004C4A RID: 19530
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStructRedirect> _ActiveStructRedirects;

		// Token: 0x04004C4B RID: 19531
		internal static int __PropertyOffset_PreIntegratedSnowBRDFTexture;

		// Token: 0x04004C4C RID: 19532
		internal static int __PropertyOffset_PreIntegratedSnowBRDFTextureName;

		// Token: 0x04004C4D RID: 19533
		[Nullable(2)]
		private FSoftObjectPath _PreIntegratedSnowBRDFTextureName;

		// Token: 0x04004C4E RID: 19534
		internal static int __PropertyOffset_BlueNoiseTexture;

		// Token: 0x04004C4F RID: 19535
		internal static int __PropertyOffset_BlueNoiseTextureName;

		// Token: 0x04004C50 RID: 19536
		[Nullable(2)]
		private FSoftObjectPath _BlueNoiseTextureName;

		// Token: 0x04004C51 RID: 19537
		internal static int __PropertyOffset_BlueNoiseScalarTexture;

		// Token: 0x04004C52 RID: 19538
		internal static int __PropertyOffset_BlueNoiseScalarTextureName;

		// Token: 0x04004C53 RID: 19539
		[Nullable(2)]
		private FSoftObjectPath _BlueNoiseScalarTextureName;

		// Token: 0x04004C54 RID: 19540
		internal static int __PropertyOffset_BlueNoiseVec2Texture;

		// Token: 0x04004C55 RID: 19541
		internal static int __PropertyOffset_BlueNoiseVec2TextureName;

		// Token: 0x04004C56 RID: 19542
		[Nullable(2)]
		private FSoftObjectPath _BlueNoiseVec2TextureName;

		// Token: 0x04004C57 RID: 19543
		internal static int __PropertyOffset_DefaultBakedBoneTexture;

		// Token: 0x04004C58 RID: 19544
		internal static int __PropertyOffset_DefaultBakedBoneTextureName;

		// Token: 0x04004C59 RID: 19545
		[Nullable(2)]
		private FSoftObjectPath _DefaultBakedBoneTextureName;

		// Token: 0x04004C5A RID: 19546
		internal static int __PropertyOffset_DefaultAnimNoiseTexture;

		// Token: 0x04004C5B RID: 19547
		internal static int __PropertyOffset_DefaultAnimNoiseTextureName;

		// Token: 0x04004C5C RID: 19548
		[Nullable(2)]
		private FSoftObjectPath _DefaultAnimNoiseTextureName;

		// Token: 0x04004C5D RID: 19549
		internal static int __PropertyOffset_MiniFontTexture;

		// Token: 0x04004C5E RID: 19550
		internal static int __PropertyOffset_MiniFontTextureName;

		// Token: 0x04004C5F RID: 19551
		[Nullable(2)]
		private FSoftObjectPath _MiniFontTextureName;

		// Token: 0x04004C60 RID: 19552
		internal static int __PropertyOffset_WeightMapPlaceholderTexture;

		// Token: 0x04004C61 RID: 19553
		internal static int __PropertyOffset_WeightMapPlaceholderTextureName;

		// Token: 0x04004C62 RID: 19554
		[Nullable(2)]
		private FSoftObjectPath _WeightMapPlaceholderTextureName;

		// Token: 0x04004C63 RID: 19555
		internal static int __PropertyOffset_LightMapDensityTexture;

		// Token: 0x04004C64 RID: 19556
		internal static int __PropertyOffset_LightMapDensityTextureName;

		// Token: 0x04004C65 RID: 19557
		[Nullable(2)]
		private FSoftObjectPath _LightMapDensityTextureName;

		// Token: 0x04004C66 RID: 19558
		internal static int __PropertyOffset_BlackTexture;

		// Token: 0x04004C67 RID: 19559
		internal static int __PropertyOffset_GameViewport;

		// Token: 0x04004C68 RID: 19560
		internal static int __PropertyOffset_DeferredCommands;

		// Token: 0x04004C69 RID: 19561
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DeferredCommands;

		// Token: 0x04004C6A RID: 19562
		internal static int __PropertyOffset_NearClipPlane;

		// Token: 0x04004C6B RID: 19563
		internal static int __PropertyOffset_bSubtitlesEnabled;

		// Token: 0x04004C6C RID: 19564
		internal static byte __PropertyMask_bSubtitlesEnabled;

		// Token: 0x04004C6D RID: 19565
		internal static int __PropertyOffset_bSubtitlesForcedOff;

		// Token: 0x04004C6E RID: 19566
		internal static byte __PropertyMask_bSubtitlesForcedOff;

		// Token: 0x04004C6F RID: 19567
		internal static int __PropertyOffset_MaximumLoopIterationCount;

		// Token: 0x04004C70 RID: 19568
		internal static int __PropertyOffset_bCanBlueprintsTickByDefault;

		// Token: 0x04004C71 RID: 19569
		internal static byte __PropertyMask_bCanBlueprintsTickByDefault;

		// Token: 0x04004C72 RID: 19570
		internal static int __PropertyOffset_bOptimizeAnimBlueprintMemberVariableAccess;

		// Token: 0x04004C73 RID: 19571
		internal static byte __PropertyMask_bOptimizeAnimBlueprintMemberVariableAccess;

		// Token: 0x04004C74 RID: 19572
		internal static int __PropertyOffset_bAllowMultiThreadedAnimationUpdate;

		// Token: 0x04004C75 RID: 19573
		internal static byte __PropertyMask_bAllowMultiThreadedAnimationUpdate;

		// Token: 0x04004C76 RID: 19574
		internal static int __PropertyOffset_bEnableEditorPSysRealtimeLOD;

		// Token: 0x04004C77 RID: 19575
		internal static byte __PropertyMask_bEnableEditorPSysRealtimeLOD;

		// Token: 0x04004C78 RID: 19576
		internal static int __PropertyOffset_bSmoothFrameRate;

		// Token: 0x04004C79 RID: 19577
		internal static byte __PropertyMask_bSmoothFrameRate;

		// Token: 0x04004C7A RID: 19578
		internal static int __PropertyOffset_bUseFixedFrameRate;

		// Token: 0x04004C7B RID: 19579
		internal static byte __PropertyMask_bUseFixedFrameRate;

		// Token: 0x04004C7C RID: 19580
		internal static int __PropertyOffset_FixedFrameRate;

		// Token: 0x04004C7D RID: 19581
		internal static int __PropertyOffset_SmoothedFrameRateRange;

		// Token: 0x04004C7E RID: 19582
		internal static int __PropertyOffset_CustomTimeStep;

		// Token: 0x04004C7F RID: 19583
		internal static int __PropertyOffset_CustomTimeStepClassName;

		// Token: 0x04004C80 RID: 19584
		[Nullable(2)]
		private FSoftClassPath _CustomTimeStepClassName;

		// Token: 0x04004C81 RID: 19585
		internal static int __PropertyOffset_TimecodeProvider;

		// Token: 0x04004C82 RID: 19586
		internal static int __PropertyOffset_TimecodeProviderClassName;

		// Token: 0x04004C83 RID: 19587
		[Nullable(2)]
		private FSoftClassPath _TimecodeProviderClassName;

		// Token: 0x04004C84 RID: 19588
		internal static int __PropertyOffset_bGenerateDefaultTimecode;

		// Token: 0x04004C85 RID: 19589
		internal static int __PropertyOffset_GenerateDefaultTimecodeFrameRate;

		// Token: 0x04004C86 RID: 19590
		internal static int __PropertyOffset_GenerateDefaultTimecodeFrameDelay;

		// Token: 0x04004C87 RID: 19591
		internal static int __PropertyOffset_bCheckForMultiplePawnsSpawnedInAFrame;

		// Token: 0x04004C88 RID: 19592
		internal static byte __PropertyMask_bCheckForMultiplePawnsSpawnedInAFrame;

		// Token: 0x04004C89 RID: 19593
		internal static int __PropertyOffset_NumPawnsAllowedToBeSpawnedInAFrame;

		// Token: 0x04004C8A RID: 19594
		internal static int __PropertyOffset_bShouldGenerateLowQualityLightmaps_DEPRECATED;

		// Token: 0x04004C8B RID: 19595
		internal static byte __PropertyMask_bShouldGenerateLowQualityLightmaps_DEPRECATED;

		// Token: 0x04004C8C RID: 19596
		internal static int __PropertyOffset_C_WorldBox;

		// Token: 0x04004C8D RID: 19597
		internal static int __PropertyOffset_C_BrushWire;

		// Token: 0x04004C8E RID: 19598
		internal static int __PropertyOffset_C_AddWire;

		// Token: 0x04004C8F RID: 19599
		internal static int __PropertyOffset_C_SubtractWire;

		// Token: 0x04004C90 RID: 19600
		internal static int __PropertyOffset_C_SemiSolidWire;

		// Token: 0x04004C91 RID: 19601
		internal static int __PropertyOffset_C_NonSolidWire;

		// Token: 0x04004C92 RID: 19602
		internal static int __PropertyOffset_C_WireBackground;

		// Token: 0x04004C93 RID: 19603
		internal static int __PropertyOffset_C_ScaleBoxHi;

		// Token: 0x04004C94 RID: 19604
		internal static int __PropertyOffset_C_VolumeCollision;

		// Token: 0x04004C95 RID: 19605
		internal static int __PropertyOffset_C_BSPCollision;

		// Token: 0x04004C96 RID: 19606
		internal static int __PropertyOffset_C_OrthoBackground;

		// Token: 0x04004C97 RID: 19607
		internal static int __PropertyOffset_C_Volume;

		// Token: 0x04004C98 RID: 19608
		internal static int __PropertyOffset_C_BrushShape;

		// Token: 0x04004C99 RID: 19609
		internal static int __PropertyOffset_StreamingDistanceFactor;

		// Token: 0x04004C9A RID: 19610
		internal static int __PropertyOffset_GameScreenshotSaveDirectory;

		// Token: 0x04004C9B RID: 19611
		[Nullable(2)]
		private FDirectoryPath _GameScreenshotSaveDirectory;

		// Token: 0x04004C9C RID: 19612
		internal static int __PropertyOffset_TransitionType;

		// Token: 0x04004C9D RID: 19613
		internal static int __PropertyOffset_TransitionDescription;

		// Token: 0x04004C9E RID: 19614
		internal static int __PropertyOffset_TransitionGameMode;

		// Token: 0x04004C9F RID: 19615
		internal static int __PropertyOffset_bAllowMatureLanguage;

		// Token: 0x04004CA0 RID: 19616
		internal static byte __PropertyMask_bAllowMatureLanguage;

		// Token: 0x04004CA1 RID: 19617
		internal static int __PropertyOffset_CameraRotationThreshold;

		// Token: 0x04004CA2 RID: 19618
		internal static int __PropertyOffset_CameraTranslationThreshold;

		// Token: 0x04004CA3 RID: 19619
		internal static int __PropertyOffset_PrimitiveProbablyVisibleTime;

		// Token: 0x04004CA4 RID: 19620
		internal static int __PropertyOffset_MaxOcclusionPixelsFraction;

		// Token: 0x04004CA5 RID: 19621
		internal static int __PropertyOffset_bPauseOnLossOfFocus;

		// Token: 0x04004CA6 RID: 19622
		internal static byte __PropertyMask_bPauseOnLossOfFocus;

		// Token: 0x04004CA7 RID: 19623
		internal static int __PropertyOffset_MaxParticleResize;

		// Token: 0x04004CA8 RID: 19624
		internal static int __PropertyOffset_MaxParticleResizeWarn;

		// Token: 0x04004CA9 RID: 19625
		internal static int __PropertyOffset_PendingDroppedNotes;

		// Token: 0x04004CAA RID: 19626
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FDropNoteInfo> _PendingDroppedNotes;

		// Token: 0x04004CAB RID: 19627
		internal static int __PropertyOffset_NetClientTicksPerSecond;

		// Token: 0x04004CAC RID: 19628
		internal static int __PropertyOffset_DisplayGamma;

		// Token: 0x04004CAD RID: 19629
		internal static int __PropertyOffset_MinDesiredFrameRate;

		// Token: 0x04004CAE RID: 19630
		internal static int __PropertyOffset_DefaultSelectedMaterialColor;

		// Token: 0x04004CAF RID: 19631
		internal static int __PropertyOffset_SelectedMaterialColor;

		// Token: 0x04004CB0 RID: 19632
		internal static int __PropertyOffset_SelectionOutlineColor;

		// Token: 0x04004CB1 RID: 19633
		internal static int __PropertyOffset_SubduedSelectionOutlineColor;

		// Token: 0x04004CB2 RID: 19634
		internal static int __PropertyOffset_SelectedMaterialColorOverride;

		// Token: 0x04004CB3 RID: 19635
		internal static int __PropertyOffset_bIsOverridingSelectedColor;

		// Token: 0x04004CB4 RID: 19636
		internal static int __PropertyOffset_bEnableOnScreenDebugMessages;

		// Token: 0x04004CB5 RID: 19637
		internal static byte __PropertyMask_bEnableOnScreenDebugMessages;

		// Token: 0x04004CB6 RID: 19638
		internal static int __PropertyOffset_bEnableOnScreenDebugMessagesDisplay;

		// Token: 0x04004CB7 RID: 19639
		internal static byte __PropertyMask_bEnableOnScreenDebugMessagesDisplay;

		// Token: 0x04004CB8 RID: 19640
		internal static int __PropertyOffset_bSuppressMapWarnings;

		// Token: 0x04004CB9 RID: 19641
		internal static byte __PropertyMask_bSuppressMapWarnings;

		// Token: 0x04004CBA RID: 19642
		internal static int __PropertyOffset_bDisableAILogging;

		// Token: 0x04004CBB RID: 19643
		internal static byte __PropertyMask_bDisableAILogging;

		// Token: 0x04004CBC RID: 19644
		internal static int __PropertyOffset_bEnableVisualLogRecordingOnStart;

		// Token: 0x04004CBD RID: 19645
		internal static int __PropertyOffset_ScreenSaverInhibitorSemaphore;

		// Token: 0x04004CBE RID: 19646
		internal static int __PropertyOffset_bLockReadOnlyLevels;

		// Token: 0x04004CBF RID: 19647
		internal static byte __PropertyMask_bLockReadOnlyLevels;

		// Token: 0x04004CC0 RID: 19648
		internal static int __PropertyOffset_ParticleEventManagerClassPath;

		// Token: 0x04004CC1 RID: 19649
		internal static int __PropertyOffset_SelectionHighlightIntensity;

		// Token: 0x04004CC2 RID: 19650
		internal static int __PropertyOffset_BSPSelectionHighlightIntensity;

		// Token: 0x04004CC3 RID: 19651
		internal static int __PropertyOffset_SelectionHighlightIntensityBillboards;

		// Token: 0x04004CC4 RID: 19652
		internal static int __PropertyOffset_NetDriverDefinitions;

		// Token: 0x04004CC5 RID: 19653
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNetDriverDefinition> _NetDriverDefinitions;

		// Token: 0x04004CC6 RID: 19654
		internal static int __PropertyOffset_ServerActors;

		// Token: 0x04004CC7 RID: 19655
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ServerActors;

		// Token: 0x04004CC8 RID: 19656
		internal static int __PropertyOffset_RuntimeServerActors;

		// Token: 0x04004CC9 RID: 19657
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _RuntimeServerActors;

		// Token: 0x04004CCA RID: 19658
		internal static int __PropertyOffset_NetErrorLogInterval;

		// Token: 0x04004CCB RID: 19659
		internal static int __PropertyOffset_bStartedLoadMapMovie;

		// Token: 0x04004CCC RID: 19660
		internal static byte __PropertyMask_bStartedLoadMapMovie;

		// Token: 0x04004CCD RID: 19661
		internal static int __PropertyOffset_NextWorldContextHandle;
	}
}
