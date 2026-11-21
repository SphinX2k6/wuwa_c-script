using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000191 RID: 401
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BlueprintGeneratedClass")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class UBlueprintGeneratedClass : UClass, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001A0C RID: 6668 RVA: 0x00027175 File Offset: 0x00025375
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlueprintGeneratedClass._ClassPtr;
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00027184 File Offset: 0x00025384
		public UBlueprintGeneratedClass() : this(BuiltinUtils.AllocNativeUObject(UBlueprintGeneratedClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x000271AC File Offset: 0x000253AC
		[NullableContext(1)]
		public UBlueprintGeneratedClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlueprintGeneratedClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x000271DF File Offset: 0x000253DF
		// (set) Token: 0x06001A10 RID: 6672 RVA: 0x000271EF File Offset: 0x000253EF
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

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x00027200 File Offset: 0x00025400
		// (set) Token: 0x06001A12 RID: 6674 RVA: 0x00027219 File Offset: 0x00025419
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

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x00027249 File Offset: 0x00025449
		// (set) Token: 0x06001A14 RID: 6676 RVA: 0x00027262 File Offset: 0x00025462
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

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001A15 RID: 6677 RVA: 0x00027294 File Offset: 0x00025494
		// (set) Token: 0x06001A16 RID: 6678 RVA: 0x000272CD File Offset: 0x000254CD
		[Nullable(1)]
		public TArray<UActorComponent> ComponentTemplates
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.ComponentTemplates.CopyAssign(value);
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x000272DB File Offset: 0x000254DB
		// (set) Token: 0x06001A18 RID: 6680 RVA: 0x000272EF File Offset: 0x000254EF
		public unsafe UStructProperty UberGraphFramePointerProperty_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStructProperty>(base.NativePtr / (IntPtr)sizeof(void*) + UBlueprintGeneratedClass.__PropertyOffset_UberGraphFramePointerProperty_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBlueprintGeneratedClass.__PropertyOffset_UberGraphFramePointerProperty_DEPRECATED, value);
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06001A19 RID: 6681 RVA: 0x00027304 File Offset: 0x00025504
		// (set) Token: 0x06001A1A RID: 6682 RVA: 0x00027318 File Offset: 0x00025518
		public unsafe UFunction UberGraphFunction
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFunction>(base.NativePtr / (IntPtr)sizeof(void*) + UBlueprintGeneratedClass.__PropertyOffset_UberGraphFunction);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBlueprintGeneratedClass.__PropertyOffset_UberGraphFunction, value);
			}
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x0002732D File Offset: 0x0002552D
		static UBlueprintGeneratedClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BlueprintGeneratedClass");
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x0002733B File Offset: 0x0002553B
		protected UBlueprintGeneratedClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000863 RID: 2147
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BlueprintGeneratedClass";

		// Token: 0x04000864 RID: 2148
		private static IntPtr _ClassPtr;

		// Token: 0x04000865 RID: 2149
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000866 RID: 2150
		internal static int __PropertyOffset_NumReplicatedProperties;

		// Token: 0x04000867 RID: 2151
		internal static int __PropertyOffset_bHasNativizedParent;

		// Token: 0x04000868 RID: 2152
		internal static byte __PropertyMask_bHasNativizedParent;

		// Token: 0x04000869 RID: 2153
		internal static int __PropertyOffset_bHasCookedComponentInstancingData;

		// Token: 0x0400086A RID: 2154
		internal static byte __PropertyMask_bHasCookedComponentInstancingData;

		// Token: 0x0400086B RID: 2155
		internal static int __PropertyOffset_ComponentTemplates;

		// Token: 0x0400086C RID: 2156
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UActorComponent> _ComponentTemplates;

		// Token: 0x0400086D RID: 2157
		internal static int __PropertyOffset_UberGraphFramePointerProperty_DEPRECATED;

		// Token: 0x0400086E RID: 2158
		internal static int __PropertyOffset_UberGraphFunction;
	}
}
