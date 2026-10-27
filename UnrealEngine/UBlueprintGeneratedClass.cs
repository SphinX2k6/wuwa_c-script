using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008C2 RID: 2242
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BlueprintGeneratedClass")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class UBlueprintGeneratedClass : UClass, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007A66 RID: 31334 RVA: 0x000AF0F5 File Offset: 0x000AD2F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlueprintGeneratedClass._ClassPtr;
		}

		// Token: 0x06007A67 RID: 31335 RVA: 0x000AF104 File Offset: 0x000AD304
		public UBlueprintGeneratedClass() : this(BuiltinUtils.AllocNativeUObject(UBlueprintGeneratedClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007A68 RID: 31336 RVA: 0x000AF12C File Offset: 0x000AD32C
		public UBlueprintGeneratedClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlueprintGeneratedClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001CE9 RID: 7401
		// (get) Token: 0x06007A69 RID: 31337 RVA: 0x000AF15F File Offset: 0x000AD35F
		// (set) Token: 0x06007A6A RID: 31338 RVA: 0x000AF16F File Offset: 0x000AD36F
		public unsafe int NumReplicatedProperties
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlueprintGeneratedClass.__PropertyOffset_NumReplicatedProperties);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlueprintGeneratedClass.__PropertyOffset_NumReplicatedProperties) = value;
			}
		}

		// Token: 0x17001CEA RID: 7402
		// (get) Token: 0x06007A6B RID: 31339 RVA: 0x000AF180 File Offset: 0x000AD380
		// (set) Token: 0x06007A6C RID: 31340 RVA: 0x000AF199 File Offset: 0x000AD399
		public unsafe bool bHasNativizedParent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBlueprintGeneratedClass.__PropertyOffset_bHasNativizedParent) & UBlueprintGeneratedClass.__PropertyMask_bHasNativizedParent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBlueprintGeneratedClass.__PropertyOffset_bHasNativizedParent) = ((*(base.NativePtr + (IntPtr)UBlueprintGeneratedClass.__PropertyOffset_bHasNativizedParent) & ~UBlueprintGeneratedClass.__PropertyMask_bHasNativizedParent) | (value ? UBlueprintGeneratedClass.__PropertyMask_bHasNativizedParent : 0));
			}
		}

		// Token: 0x17001CEB RID: 7403
		// (get) Token: 0x06007A6D RID: 31341 RVA: 0x000AF1C9 File Offset: 0x000AD3C9
		// (set) Token: 0x06007A6E RID: 31342 RVA: 0x000AF1E2 File Offset: 0x000AD3E2
		public unsafe bool bHasCookedComponentInstancingData
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBlueprintGeneratedClass.__PropertyOffset_bHasCookedComponentInstancingData) & UBlueprintGeneratedClass.__PropertyMask_bHasCookedComponentInstancingData) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBlueprintGeneratedClass.__PropertyOffset_bHasCookedComponentInstancingData) = ((*(base.NativePtr + (IntPtr)UBlueprintGeneratedClass.__PropertyOffset_bHasCookedComponentInstancingData) & ~UBlueprintGeneratedClass.__PropertyMask_bHasCookedComponentInstancingData) | (value ? UBlueprintGeneratedClass.__PropertyMask_bHasCookedComponentInstancingData : 0));
			}
		}

		// Token: 0x17001CEC RID: 7404
		// (get) Token: 0x06007A6F RID: 31343 RVA: 0x000AF214 File Offset: 0x000AD414
		// (set) Token: 0x06007A70 RID: 31344 RVA: 0x000AF24D File Offset: 0x000AD44D
		public TArray<UDynamicBlueprintBinding> DynamicBindingObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UDynamicBlueprintBinding> result;
				if ((result = this._DynamicBindingObjects) == null)
				{
					result = (this._DynamicBindingObjects = new TArray<UDynamicBlueprintBinding>(base.NativePtr + (IntPtr)UBlueprintGeneratedClass.__PropertyOffset_DynamicBindingObjects, this));
				}
				return result;
			}
			set
			{
				this.DynamicBindingObjects.CopyAssign(value);
			}
		}

		// Token: 0x17001CED RID: 7405
		// (get) Token: 0x06007A71 RID: 31345 RVA: 0x000AF25C File Offset: 0x000AD45C
		// (set) Token: 0x06007A72 RID: 31346 RVA: 0x000AF295 File Offset: 0x000AD495
		public TArray<UActorComponent> ComponentTemplates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UActorComponent> result;
				if ((result = this._ComponentTemplates) == null)
				{
					result = (this._ComponentTemplates = new TArray<UActorComponent>(base.NativePtr + (IntPtr)UBlueprintGeneratedClass.__PropertyOffset_ComponentTemplates, this));
				}
				return result;
			}
			set
			{
				this.ComponentTemplates.CopyAssign(value);
			}
		}

		// Token: 0x17001CEE RID: 7406
		// (get) Token: 0x06007A73 RID: 31347 RVA: 0x000AF2A4 File Offset: 0x000AD4A4
		// (set) Token: 0x06007A74 RID: 31348 RVA: 0x000AF2DD File Offset: 0x000AD4DD
		public TArray<UTimelineTemplate> Timelines
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UTimelineTemplate> result;
				if ((result = this._Timelines) == null)
				{
					result = (this._Timelines = new TArray<UTimelineTemplate>(base.NativePtr + (IntPtr)UBlueprintGeneratedClass.__PropertyOffset_Timelines, this));
				}
				return result;
			}
			set
			{
				this.Timelines.CopyAssign(value);
			}
		}

		// Token: 0x17001CEF RID: 7407
		// (get) Token: 0x06007A75 RID: 31349 RVA: 0x000AF2EC File Offset: 0x000AD4EC
		// (set) Token: 0x06007A76 RID: 31350 RVA: 0x000AF325 File Offset: 0x000AD525
		public TArray<FBPComponentClassOverride> ComponentClassOverrides
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBPComponentClassOverride> result;
				if ((result = this._ComponentClassOverrides) == null)
				{
					result = (this._ComponentClassOverrides = new TArray<FBPComponentClassOverride>(base.NativePtr + (IntPtr)UBlueprintGeneratedClass.__PropertyOffset_ComponentClassOverrides, this));
				}
				return result;
			}
			set
			{
				this.ComponentClassOverrides.CopyAssign(value);
			}
		}

		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x06007A77 RID: 31351 RVA: 0x000AF333 File Offset: 0x000AD533
		// (set) Token: 0x06007A78 RID: 31352 RVA: 0x000AF347 File Offset: 0x000AD547
		[Nullable(2)]
		public unsafe USimpleConstructionScript SimpleConstructionScript
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USimpleConstructionScript>(base.NativePtr / (IntPtr)sizeof(void*) + UBlueprintGeneratedClass.__PropertyOffset_SimpleConstructionScript);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBlueprintGeneratedClass.__PropertyOffset_SimpleConstructionScript, value);
			}
		}

		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x06007A79 RID: 31353 RVA: 0x000AF35C File Offset: 0x000AD55C
		// (set) Token: 0x06007A7A RID: 31354 RVA: 0x000AF370 File Offset: 0x000AD570
		[Nullable(2)]
		public unsafe UInheritableComponentHandler InheritableComponentHandler
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInheritableComponentHandler>(base.NativePtr / (IntPtr)sizeof(void*) + UBlueprintGeneratedClass.__PropertyOffset_InheritableComponentHandler);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBlueprintGeneratedClass.__PropertyOffset_InheritableComponentHandler, value);
			}
		}

		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x06007A7B RID: 31355 RVA: 0x000AF385 File Offset: 0x000AD585
		// (set) Token: 0x06007A7C RID: 31356 RVA: 0x000AF399 File Offset: 0x000AD599
		[Nullable(2)]
		public unsafe UStructProperty UberGraphFramePointerProperty_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStructProperty>(base.NativePtr / (IntPtr)sizeof(void*) + UBlueprintGeneratedClass.__PropertyOffset_UberGraphFramePointerProperty_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBlueprintGeneratedClass.__PropertyOffset_UberGraphFramePointerProperty_DEPRECATED, value);
			}
		}

		// Token: 0x17001CF3 RID: 7411
		// (get) Token: 0x06007A7D RID: 31357 RVA: 0x000AF3AE File Offset: 0x000AD5AE
		// (set) Token: 0x06007A7E RID: 31358 RVA: 0x000AF3C2 File Offset: 0x000AD5C2
		[Nullable(2)]
		public unsafe UFunction UberGraphFunction
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFunction>(base.NativePtr / (IntPtr)sizeof(void*) + UBlueprintGeneratedClass.__PropertyOffset_UberGraphFunction);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBlueprintGeneratedClass.__PropertyOffset_UberGraphFunction, value);
			}
		}

		// Token: 0x17001CF4 RID: 7412
		// (get) Token: 0x06007A7F RID: 31359 RVA: 0x000AF3D8 File Offset: 0x000AD5D8
		// (set) Token: 0x06007A80 RID: 31360 RVA: 0x000AF411 File Offset: 0x000AD611
		public TMap<FName, FBlueprintCookedComponentInstancingData> CookedComponentInstancingData
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FBlueprintCookedComponentInstancingData> result;
				if ((result = this._CookedComponentInstancingData) == null)
				{
					result = (this._CookedComponentInstancingData = new TMap<FName, FBlueprintCookedComponentInstancingData>(base.NativePtr + (IntPtr)UBlueprintGeneratedClass.__PropertyOffset_CookedComponentInstancingData, this));
				}
				return result;
			}
			set
			{
				this.CookedComponentInstancingData.CopyAssign(value);
			}
		}

		// Token: 0x06007A81 RID: 31361 RVA: 0x000AF41F File Offset: 0x000AD61F
		static UBlueprintGeneratedClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BlueprintGeneratedClass");
		}

		// Token: 0x06007A82 RID: 31362 RVA: 0x000AF42D File Offset: 0x000AD62D
		protected UBlueprintGeneratedClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003ADA RID: 15066
		public new const string __ObjectPath = "/Script/Engine.BlueprintGeneratedClass";

		// Token: 0x04003ADB RID: 15067
		private static IntPtr _ClassPtr;

		// Token: 0x04003ADC RID: 15068
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003ADD RID: 15069
		internal static int __PropertyOffset_NumReplicatedProperties;

		// Token: 0x04003ADE RID: 15070
		internal static int __PropertyOffset_bHasNativizedParent;

		// Token: 0x04003ADF RID: 15071
		internal static byte __PropertyMask_bHasNativizedParent;

		// Token: 0x04003AE0 RID: 15072
		internal static int __PropertyOffset_bHasCookedComponentInstancingData;

		// Token: 0x04003AE1 RID: 15073
		internal static byte __PropertyMask_bHasCookedComponentInstancingData;

		// Token: 0x04003AE2 RID: 15074
		internal static int __PropertyOffset_DynamicBindingObjects;

		// Token: 0x04003AE3 RID: 15075
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UDynamicBlueprintBinding> _DynamicBindingObjects;

		// Token: 0x04003AE4 RID: 15076
		internal static int __PropertyOffset_ComponentTemplates;

		// Token: 0x04003AE5 RID: 15077
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UActorComponent> _ComponentTemplates;

		// Token: 0x04003AE6 RID: 15078
		internal static int __PropertyOffset_Timelines;

		// Token: 0x04003AE7 RID: 15079
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTimelineTemplate> _Timelines;

		// Token: 0x04003AE8 RID: 15080
		internal static int __PropertyOffset_ComponentClassOverrides;

		// Token: 0x04003AE9 RID: 15081
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBPComponentClassOverride> _ComponentClassOverrides;

		// Token: 0x04003AEA RID: 15082
		internal static int __PropertyOffset_SimpleConstructionScript;

		// Token: 0x04003AEB RID: 15083
		internal static int __PropertyOffset_InheritableComponentHandler;

		// Token: 0x04003AEC RID: 15084
		internal static int __PropertyOffset_UberGraphFramePointerProperty_DEPRECATED;

		// Token: 0x04003AED RID: 15085
		internal static int __PropertyOffset_UberGraphFunction;

		// Token: 0x04003AEE RID: 15086
		internal static int __PropertyOffset_CookedComponentInstancingData;

		// Token: 0x04003AEF RID: 15087
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FBlueprintCookedComponentInstancingData> _CookedComponentInstancingData;
	}
}
