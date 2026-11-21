using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003A0 RID: 928
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGamePartition.GamePartitionSubsystem")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UGamePartitionSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005BF5 RID: 23541 RVA: 0x00081857 File Offset: 0x0007FA57
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGamePartitionSubsystem._ClassPtr;
		}

		// Token: 0x06005BF6 RID: 23542 RVA: 0x00081864 File Offset: 0x0007FA64
		public UGamePartitionSubsystem() : this(BuiltinUtils.AllocNativeUObject(UGamePartitionSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005BF7 RID: 23543 RVA: 0x0008188C File Offset: 0x0007FA8C
		public UGamePartitionSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGamePartitionSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x06005BF8 RID: 23544 RVA: 0x000818C0 File Offset: 0x0007FAC0
		// (set) Token: 0x06005BF9 RID: 23545 RVA: 0x000818FA File Offset: 0x0007FAFA
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

		// Token: 0x06005BFA RID: 23546 RVA: 0x00081908 File Offset: 0x0007FB08
		[NullableContext(2)]
		public UGamePartition GetGamePartition(EGamePartitionCellSizeType CellSizeType = EGamePartitionCellSizeType.Default)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGamePartition>(UGamePartitionSubsystem.__GetGamePartition_Internal(base.NativePtr, CellSizeType));
		}

		// Token: 0x06005BFB RID: 23547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGamePartition_Internal(IntPtr @this, EGamePartitionCellSizeType CellSizeType);

		// Token: 0x06005BFC RID: 23548 RVA: 0x0008191B File Offset: 0x0007FB1B
		static UGamePartitionSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGamePartition.GamePartitionSubsystem");
		}

		// Token: 0x06005BFD RID: 23549 RVA: 0x00081929 File Offset: 0x0007FB29
		protected UGamePartitionSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002644 RID: 9796
		public new const string __ObjectPath = "/Script/KuroGamePartition.GamePartitionSubsystem";

		// Token: 0x04002645 RID: 9797
		private static IntPtr _ClassPtr;

		// Token: 0x04002646 RID: 9798
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002647 RID: 9799
		internal static int __PropertyOffset_GamePartition;

		// Token: 0x04002648 RID: 9800
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<UGamePartition> _GamePartition;
	}
}
