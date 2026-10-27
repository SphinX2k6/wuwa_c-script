using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014CA RID: 5322
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInputBlueprint")]
	[UnrealStructLayout(352, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UHoudiniInputBlueprint : UHoudiniInputObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060134BC RID: 79036 RVA: 0x001C5F64 File Offset: 0x001C4164
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInputBlueprint._ClassPtr;
		}

		// Token: 0x060134BD RID: 79037 RVA: 0x001C5F70 File Offset: 0x001C4170
		public UHoudiniInputBlueprint() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputBlueprint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060134BE RID: 79038 RVA: 0x001C5F98 File Offset: 0x001C4198
		public UHoudiniInputBlueprint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputBlueprint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B37 RID: 19255
		// (get) Token: 0x060134BF RID: 79039 RVA: 0x001C5FCC File Offset: 0x001C41CC
		// (set) Token: 0x060134C0 RID: 79040 RVA: 0x001C6005 File Offset: 0x001C4205
		public TArray<UHoudiniInputSceneComponent> BPComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniInputSceneComponent> result;
				if ((result = this._BPComponents) == null)
				{
					result = (this._BPComponents = new TArray<UHoudiniInputSceneComponent>(base.NativePtr + (IntPtr)UHoudiniInputBlueprint.__PropertyOffset_BPComponents, this));
				}
				return result;
			}
			set
			{
				this.BPComponents.CopyAssign(value);
			}
		}

		// Token: 0x17004B38 RID: 19256
		// (get) Token: 0x060134C1 RID: 79041 RVA: 0x001C6014 File Offset: 0x001C4214
		// (set) Token: 0x060134C2 RID: 79042 RVA: 0x001C604D File Offset: 0x001C424D
		public TSet<TSoftObjectPtr<UObject>> BPSceneComponents
		{
			get
			{
				base.FastCheckIsValid();
				TSet<TSoftObjectPtr<UObject>> result;
				if ((result = this._BPSceneComponents) == null)
				{
					result = (this._BPSceneComponents = new TSet<TSoftObjectPtr<UObject>>(base.NativePtr + (IntPtr)UHoudiniInputBlueprint.__PropertyOffset_BPSceneComponents, this));
				}
				return result;
			}
			set
			{
				this.BPSceneComponents.CopyAssign(value);
			}
		}

		// Token: 0x17004B39 RID: 19257
		// (get) Token: 0x060134C3 RID: 79043 RVA: 0x001C605B File Offset: 0x001C425B
		// (set) Token: 0x060134C4 RID: 79044 RVA: 0x001C606B File Offset: 0x001C426B
		public unsafe int LastUpdateNumComponentsAdded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputBlueprint.__PropertyOffset_LastUpdateNumComponentsAdded);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputBlueprint.__PropertyOffset_LastUpdateNumComponentsAdded) = value;
			}
		}

		// Token: 0x17004B3A RID: 19258
		// (get) Token: 0x060134C5 RID: 79045 RVA: 0x001C607C File Offset: 0x001C427C
		// (set) Token: 0x060134C6 RID: 79046 RVA: 0x001C608C File Offset: 0x001C428C
		public unsafe int LastUpdateNumComponentsRemoved
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputBlueprint.__PropertyOffset_LastUpdateNumComponentsRemoved);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputBlueprint.__PropertyOffset_LastUpdateNumComponentsRemoved) = value;
			}
		}

		// Token: 0x060134C7 RID: 79047 RVA: 0x001C609D File Offset: 0x001C429D
		static UHoudiniInputBlueprint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInputBlueprint");
		}

		// Token: 0x060134C8 RID: 79048 RVA: 0x001C60AB File Offset: 0x001C42AB
		protected UHoudiniInputBlueprint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A6BF RID: 42687
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInputBlueprint";

		// Token: 0x0400A6C0 RID: 42688
		private static IntPtr _ClassPtr;

		// Token: 0x0400A6C1 RID: 42689
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A6C2 RID: 42690
		internal static int __PropertyOffset_BPComponents;

		// Token: 0x0400A6C3 RID: 42691
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniInputSceneComponent> _BPComponents;

		// Token: 0x0400A6C4 RID: 42692
		internal static int __PropertyOffset_BPSceneComponents;

		// Token: 0x0400A6C5 RID: 42693
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TSet<TSoftObjectPtr<UObject>> _BPSceneComponents;

		// Token: 0x0400A6C6 RID: 42694
		internal static int __PropertyOffset_LastUpdateNumComponentsAdded;

		// Token: 0x0400A6C7 RID: 42695
		internal static int __PropertyOffset_LastUpdateNumComponentsRemoved;
	}
}
