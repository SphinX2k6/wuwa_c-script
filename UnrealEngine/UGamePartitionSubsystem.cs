using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001874 RID: 6260
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGamePartition.GamePartitionSubsystem")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UGamePartitionSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060170E0 RID: 94432 RVA: 0x0021982D File Offset: 0x00217A2D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGamePartitionSubsystem._ClassPtr;
		}

		// Token: 0x060170E1 RID: 94433 RVA: 0x0021983C File Offset: 0x00217A3C
		public UGamePartitionSubsystem() : this(BuiltinUtils.AllocNativeUObject(UGamePartitionSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060170E2 RID: 94434 RVA: 0x00219864 File Offset: 0x00217A64
		public UGamePartitionSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGamePartitionSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005CB4 RID: 23732
		// (get) Token: 0x060170E3 RID: 94435 RVA: 0x00219898 File Offset: 0x00217A98
		// (set) Token: 0x060170E4 RID: 94436 RVA: 0x002198D2 File Offset: 0x00217AD2
		public TFixedArray<UGamePartition> GamePartition
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<UGamePartition> result;
				if ((result = this._GamePartition) == null)
				{
					result = (this._GamePartition = new TFixedArray<UGamePartition>(base.NativePtr + (IntPtr)UGamePartitionSubsystem.__PropertyOffset_GamePartition, 2, this));
				}
				return result;
			}
			set
			{
				this.GamePartition.CopyAssign(value);
			}
		}

		// Token: 0x060170E5 RID: 94437 RVA: 0x002198E0 File Offset: 0x00217AE0
		[NullableContext(2)]
		public UGamePartition GetGamePartition(EGamePartitionCellSizeType CellSizeType = EGamePartitionCellSizeType.Default)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGamePartition>(UGamePartitionSubsystem.__GetGamePartition_Internal(base.NativePtr, CellSizeType));
		}

		// Token: 0x060170E6 RID: 94438
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGamePartition_Internal(IntPtr @this, EGamePartitionCellSizeType CellSizeType);

		// Token: 0x060170E7 RID: 94439 RVA: 0x002198F3 File Offset: 0x00217AF3
		static UGamePartitionSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGamePartition.GamePartitionSubsystem");
		}

		// Token: 0x060170E8 RID: 94440 RVA: 0x00219901 File Offset: 0x00217B01
		protected UGamePartitionSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C827 RID: 51239
		public new const string __ObjectPath = "/Script/KuroGamePartition.GamePartitionSubsystem";

		// Token: 0x0400C828 RID: 51240
		private static IntPtr _ClassPtr;

		// Token: 0x0400C829 RID: 51241
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C82A RID: 51242
		internal static int __PropertyOffset_GamePartition;

		// Token: 0x0400C82B RID: 51243
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<UGamePartition> _GamePartition;
	}
}
