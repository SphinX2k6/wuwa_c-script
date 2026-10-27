using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B10 RID: 6928
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalHeightMapComponent")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UKuroGlobalHeightMapComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A0C5 RID: 106693 RVA: 0x0026744F File Offset: 0x0026564F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGlobalHeightMapComponent._ClassPtr;
		}

		// Token: 0x0601A0C6 RID: 106694 RVA: 0x0026745C File Offset: 0x0026565C
		public UKuroGlobalHeightMapComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroGlobalHeightMapComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A0C7 RID: 106695 RVA: 0x00267484 File Offset: 0x00265684
		public UKuroGlobalHeightMapComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGlobalHeightMapComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006882 RID: 26754
		// (get) Token: 0x0601A0C8 RID: 106696 RVA: 0x002674B7 File Offset: 0x002656B7
		// (set) Token: 0x0601A0C9 RID: 106697 RVA: 0x002674CB File Offset: 0x002656CB
		[Nullable(2)]
		public unsafe UKuroHeightMapSettings HeightMapSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroHeightMapSettings>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGlobalHeightMapComponent.__PropertyOffset_HeightMapSettings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGlobalHeightMapComponent.__PropertyOffset_HeightMapSettings, value);
			}
		}

		// Token: 0x17006883 RID: 26755
		// (get) Token: 0x0601A0CA RID: 106698 RVA: 0x002674E0 File Offset: 0x002656E0
		// (set) Token: 0x0601A0CB RID: 106699 RVA: 0x002674F0 File Offset: 0x002656F0
		public unsafe int LoadNumPerSidePc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalHeightMapComponent.__PropertyOffset_LoadNumPerSidePc);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalHeightMapComponent.__PropertyOffset_LoadNumPerSidePc) = value;
			}
		}

		// Token: 0x17006884 RID: 26756
		// (get) Token: 0x0601A0CC RID: 106700 RVA: 0x00267501 File Offset: 0x00265701
		// (set) Token: 0x0601A0CD RID: 106701 RVA: 0x00267511 File Offset: 0x00265711
		public unsafe int LoadNumPerSideMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalHeightMapComponent.__PropertyOffset_LoadNumPerSideMobile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalHeightMapComponent.__PropertyOffset_LoadNumPerSideMobile) = value;
			}
		}

		// Token: 0x17006885 RID: 26757
		// (get) Token: 0x0601A0CE RID: 106702 RVA: 0x00267522 File Offset: 0x00265722
		// (set) Token: 0x0601A0CF RID: 106703 RVA: 0x00267532 File Offset: 0x00265732
		public unsafe bool EnableHeightOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalHeightMapComponent.__PropertyOffset_EnableHeightOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalHeightMapComponent.__PropertyOffset_EnableHeightOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006886 RID: 26758
		// (get) Token: 0x0601A0D0 RID: 106704 RVA: 0x00267543 File Offset: 0x00265743
		// (set) Token: 0x0601A0D1 RID: 106705 RVA: 0x00267553 File Offset: 0x00265753
		public unsafe float HeightOverrideValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGlobalHeightMapComponent.__PropertyOffset_HeightOverrideValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGlobalHeightMapComponent.__PropertyOffset_HeightOverrideValue) = value;
			}
		}

		// Token: 0x17006887 RID: 26759
		// (get) Token: 0x0601A0D2 RID: 106706 RVA: 0x00267564 File Offset: 0x00265764
		// (set) Token: 0x0601A0D3 RID: 106707 RVA: 0x0026759D File Offset: 0x0026579D
		public TArray<UObject> LoadedTextures
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._LoadedTextures) == null)
				{
					result = (this._LoadedTextures = new TArray<UObject>(base.NativePtr + (IntPtr)UKuroGlobalHeightMapComponent.__PropertyOffset_LoadedTextures, this));
				}
				return result;
			}
			set
			{
				this.LoadedTextures.CopyAssign(value);
			}
		}

		// Token: 0x17006888 RID: 26760
		// (get) Token: 0x0601A0D4 RID: 106708 RVA: 0x002675AC File Offset: 0x002657AC
		// (set) Token: 0x0601A0D5 RID: 106709 RVA: 0x002675E5 File Offset: 0x002657E5
		public TArray<float> LoadedTexturesHeight
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._LoadedTexturesHeight) == null)
				{
					result = (this._LoadedTexturesHeight = new TArray<float>(base.NativePtr + (IntPtr)UKuroGlobalHeightMapComponent.__PropertyOffset_LoadedTexturesHeight, this));
				}
				return result;
			}
			set
			{
				this.LoadedTexturesHeight.CopyAssign(value);
			}
		}

		// Token: 0x0601A0D6 RID: 106710 RVA: 0x002675F3 File Offset: 0x002657F3
		public void Update()
		{
			UKuroGlobalHeightMapComponent.__Update_Internal(base.NativePtr);
		}

		// Token: 0x0601A0D7 RID: 106711
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Update_Internal(IntPtr @this);

		// Token: 0x0601A0D8 RID: 106712 RVA: 0x00267600 File Offset: 0x00265800
		static UKuroGlobalHeightMapComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalHeightMapComponent");
		}

		// Token: 0x0601A0D9 RID: 106713 RVA: 0x0026760E File Offset: 0x0026580E
		protected UKuroGlobalHeightMapComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E256 RID: 57942
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalHeightMapComponent";

		// Token: 0x0400E257 RID: 57943
		private static IntPtr _ClassPtr;

		// Token: 0x0400E258 RID: 57944
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E259 RID: 57945
		internal static int __PropertyOffset_HeightMapSettings;

		// Token: 0x0400E25A RID: 57946
		internal static int __PropertyOffset_LoadNumPerSidePc;

		// Token: 0x0400E25B RID: 57947
		internal static int __PropertyOffset_LoadNumPerSideMobile;

		// Token: 0x0400E25C RID: 57948
		internal static int __PropertyOffset_EnableHeightOverride;

		// Token: 0x0400E25D RID: 57949
		internal static int __PropertyOffset_HeightOverrideValue;

		// Token: 0x0400E25E RID: 57950
		internal static int __PropertyOffset_LoadedTextures;

		// Token: 0x0400E25F RID: 57951
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _LoadedTextures;

		// Token: 0x0400E260 RID: 57952
		internal static int __PropertyOffset_LoadedTexturesHeight;

		// Token: 0x0400E261 RID: 57953
		[Nullable(2)]
		private TArray<float> _LoadedTexturesHeight;
	}
}
