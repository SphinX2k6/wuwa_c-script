using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008B8 RID: 2232
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Blueprint")]
	[UnrealStructLayout(1240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1240)]
	public class UBlueprint : UBlueprintCore, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060079F1 RID: 31217 RVA: 0x000AE6AE File Offset: 0x000AC8AE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlueprint._ClassPtr;
		}

		// Token: 0x060079F2 RID: 31218 RVA: 0x000AE6BC File Offset: 0x000AC8BC
		public UBlueprint() : this(BuiltinUtils.AllocNativeUObject(UBlueprint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060079F3 RID: 31219 RVA: 0x000AE6E4 File Offset: 0x000AC8E4
		public UBlueprint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlueprint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001CCF RID: 7375
		// (get) Token: 0x060079F4 RID: 31220 RVA: 0x000AE717 File Offset: 0x000AC917
		// (set) Token: 0x060079F5 RID: 31221 RVA: 0x000AE72B File Offset: 0x000AC92B
		public unsafe UClassStackOnlyPtr ParentClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_ParentClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_ParentClass) = value;
			}
		}

		// Token: 0x17001CD0 RID: 7376
		// (get) Token: 0x060079F6 RID: 31222 RVA: 0x000AE740 File Offset: 0x000AC940
		// (set) Token: 0x060079F7 RID: 31223 RVA: 0x000AE754 File Offset: 0x000AC954
		[Nullable(0)]
		public unsafe TEnumAsByte<EBlueprintType> BlueprintType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_BlueprintType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_BlueprintType) = value;
			}
		}

		// Token: 0x17001CD1 RID: 7377
		// (get) Token: 0x060079F8 RID: 31224 RVA: 0x000AE769 File Offset: 0x000AC969
		// (set) Token: 0x060079F9 RID: 31225 RVA: 0x000AE782 File Offset: 0x000AC982
		public unsafe bool bRecompileOnLoad
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_bRecompileOnLoad) & UBlueprint.__PropertyMask_bRecompileOnLoad) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBlueprint.__PropertyOffset_bRecompileOnLoad) = ((*(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_bRecompileOnLoad) & ~UBlueprint.__PropertyMask_bRecompileOnLoad) | (value ? UBlueprint.__PropertyMask_bRecompileOnLoad : 0));
			}
		}

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x060079FA RID: 31226 RVA: 0x000AE7B2 File Offset: 0x000AC9B2
		// (set) Token: 0x060079FB RID: 31227 RVA: 0x000AE7CB File Offset: 0x000AC9CB
		public unsafe bool bHasBeenRegenerated
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_bHasBeenRegenerated) & UBlueprint.__PropertyMask_bHasBeenRegenerated) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBlueprint.__PropertyOffset_bHasBeenRegenerated) = ((*(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_bHasBeenRegenerated) & ~UBlueprint.__PropertyMask_bHasBeenRegenerated) | (value ? UBlueprint.__PropertyMask_bHasBeenRegenerated : 0));
			}
		}

		// Token: 0x17001CD3 RID: 7379
		// (get) Token: 0x060079FC RID: 31228 RVA: 0x000AE7FB File Offset: 0x000AC9FB
		// (set) Token: 0x060079FD RID: 31229 RVA: 0x000AE814 File Offset: 0x000ACA14
		public unsafe bool bIsRegeneratingOnLoad
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_bIsRegeneratingOnLoad) & UBlueprint.__PropertyMask_bIsRegeneratingOnLoad) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBlueprint.__PropertyOffset_bIsRegeneratingOnLoad) = ((*(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_bIsRegeneratingOnLoad) & ~UBlueprint.__PropertyMask_bIsRegeneratingOnLoad) | (value ? UBlueprint.__PropertyMask_bIsRegeneratingOnLoad : 0));
			}
		}

		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x060079FE RID: 31230 RVA: 0x000AE844 File Offset: 0x000ACA44
		// (set) Token: 0x060079FF RID: 31231 RVA: 0x000AE854 File Offset: 0x000ACA54
		public unsafe int BlueprintSystemVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_BlueprintSystemVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_BlueprintSystemVersion) = value;
			}
		}

		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x06007A00 RID: 31232 RVA: 0x000AE865 File Offset: 0x000ACA65
		// (set) Token: 0x06007A01 RID: 31233 RVA: 0x000AE879 File Offset: 0x000ACA79
		[Nullable(2)]
		public unsafe USimpleConstructionScript SimpleConstructionScript
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USimpleConstructionScript>(base.NativePtr / (IntPtr)sizeof(void*) + UBlueprint.__PropertyOffset_SimpleConstructionScript);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBlueprint.__PropertyOffset_SimpleConstructionScript, value);
			}
		}

		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x06007A02 RID: 31234 RVA: 0x000AE890 File Offset: 0x000ACA90
		// (set) Token: 0x06007A03 RID: 31235 RVA: 0x000AE8C9 File Offset: 0x000ACAC9
		public TArray<UActorComponent> ComponentTemplates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UActorComponent> result;
				if ((result = this._ComponentTemplates) == null)
				{
					result = (this._ComponentTemplates = new TArray<UActorComponent>(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_ComponentTemplates, this));
				}
				return result;
			}
			set
			{
				this.ComponentTemplates.CopyAssign(value);
			}
		}

		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x06007A04 RID: 31236 RVA: 0x000AE8D8 File Offset: 0x000ACAD8
		// (set) Token: 0x06007A05 RID: 31237 RVA: 0x000AE911 File Offset: 0x000ACB11
		public TArray<UTimelineTemplate> Timelines
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UTimelineTemplate> result;
				if ((result = this._Timelines) == null)
				{
					result = (this._Timelines = new TArray<UTimelineTemplate>(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_Timelines, this));
				}
				return result;
			}
			set
			{
				this.Timelines.CopyAssign(value);
			}
		}

		// Token: 0x17001CD8 RID: 7384
		// (get) Token: 0x06007A06 RID: 31238 RVA: 0x000AE920 File Offset: 0x000ACB20
		// (set) Token: 0x06007A07 RID: 31239 RVA: 0x000AE959 File Offset: 0x000ACB59
		public TArray<FBPComponentClassOverride> ComponentClassOverrides
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBPComponentClassOverride> result;
				if ((result = this._ComponentClassOverrides) == null)
				{
					result = (this._ComponentClassOverrides = new TArray<FBPComponentClassOverride>(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_ComponentClassOverrides, this));
				}
				return result;
			}
			set
			{
				this.ComponentClassOverrides.CopyAssign(value);
			}
		}

		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x06007A08 RID: 31240 RVA: 0x000AE967 File Offset: 0x000ACB67
		// (set) Token: 0x06007A09 RID: 31241 RVA: 0x000AE97B File Offset: 0x000ACB7B
		[Nullable(2)]
		public unsafe UInheritableComponentHandler InheritableComponentHandler
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInheritableComponentHandler>(base.NativePtr / (IntPtr)sizeof(void*) + UBlueprint.__PropertyOffset_InheritableComponentHandler);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBlueprint.__PropertyOffset_InheritableComponentHandler, value);
			}
		}

		// Token: 0x06007A0A RID: 31242 RVA: 0x000AE990 File Offset: 0x000ACB90
		static UBlueprint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Blueprint");
		}

		// Token: 0x06007A0B RID: 31243 RVA: 0x000AE99E File Offset: 0x000ACB9E
		protected UBlueprint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003A9D RID: 15005
		public new const string __ObjectPath = "/Script/Engine.Blueprint";

		// Token: 0x04003A9E RID: 15006
		private static IntPtr _ClassPtr;

		// Token: 0x04003A9F RID: 15007
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003AA0 RID: 15008
		internal static int __PropertyOffset_ParentClass;

		// Token: 0x04003AA1 RID: 15009
		internal static int __PropertyOffset_BlueprintType;

		// Token: 0x04003AA2 RID: 15010
		internal static int __PropertyOffset_bRecompileOnLoad;

		// Token: 0x04003AA3 RID: 15011
		internal static byte __PropertyMask_bRecompileOnLoad;

		// Token: 0x04003AA4 RID: 15012
		internal static int __PropertyOffset_bHasBeenRegenerated;

		// Token: 0x04003AA5 RID: 15013
		internal static byte __PropertyMask_bHasBeenRegenerated;

		// Token: 0x04003AA6 RID: 15014
		internal static int __PropertyOffset_bIsRegeneratingOnLoad;

		// Token: 0x04003AA7 RID: 15015
		internal static byte __PropertyMask_bIsRegeneratingOnLoad;

		// Token: 0x04003AA8 RID: 15016
		internal static int __PropertyOffset_BlueprintSystemVersion;

		// Token: 0x04003AA9 RID: 15017
		internal static int __PropertyOffset_SimpleConstructionScript;

		// Token: 0x04003AAA RID: 15018
		internal static int __PropertyOffset_ComponentTemplates;

		// Token: 0x04003AAB RID: 15019
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UActorComponent> _ComponentTemplates;

		// Token: 0x04003AAC RID: 15020
		internal static int __PropertyOffset_Timelines;

		// Token: 0x04003AAD RID: 15021
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTimelineTemplate> _Timelines;

		// Token: 0x04003AAE RID: 15022
		internal static int __PropertyOffset_ComponentClassOverrides;

		// Token: 0x04003AAF RID: 15023
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBPComponentClassOverride> _ComponentClassOverrides;

		// Token: 0x04003AB0 RID: 15024
		internal static int __PropertyOffset_InheritableComponentHandler;
	}
}
