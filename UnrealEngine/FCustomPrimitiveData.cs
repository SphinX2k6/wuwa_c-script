using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200098E RID: 2446
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CustomPrimitiveData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FCustomPrimitiveData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008A31 RID: 35377 RVA: 0x000C5E72 File Offset: 0x000C4072
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCustomPrimitiveData._ScriptStructPtr != 0) ? FCustomPrimitiveData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CustomPrimitiveData", ref FCustomPrimitiveData._ScriptStructPtr);
		}

		// Token: 0x17002090 RID: 8336
		// (get) Token: 0x06008A32 RID: 35378 RVA: 0x000C5E98 File Offset: 0x000C4098
		// (set) Token: 0x06008A33 RID: 35379 RVA: 0x000C5EDB File Offset: 0x000C40DB
		public TArray<float> Data
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new TArray<float>(base.NativePtr + (IntPtr)FCustomPrimitiveData.__PropertyOffset_Data, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Data.CopyAssign(value);
			}
		}

		// Token: 0x06008A34 RID: 35380 RVA: 0x000C5EE9 File Offset: 0x000C40E9
		public FCustomPrimitiveData()
		{
		}

		// Token: 0x06008A35 RID: 35381 RVA: 0x000C5EF1 File Offset: 0x000C40F1
		public FCustomPrimitiveData(TArray<float> Data)
		{
			this.Data = Data;
		}

		// Token: 0x06008A36 RID: 35382 RVA: 0x000C5F00 File Offset: 0x000C4100
		protected override IntPtr GetUStructPtr()
		{
			return FCustomPrimitiveData.StaticStruct();
		}

		// Token: 0x06008A37 RID: 35383 RVA: 0x000C5F0C File Offset: 0x000C410C
		[NullableContext(2)]
		public FCustomPrimitiveData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008A38 RID: 35384 RVA: 0x000C5F16 File Offset: 0x000C4116
		public FCustomPrimitiveData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008A39 RID: 35385 RVA: 0x000C5F21 File Offset: 0x000C4121
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCustomPrimitiveData(Pointer, false, true);
		}

		// Token: 0x06008A3A RID: 35386 RVA: 0x000C5F2B File Offset: 0x000C412B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCustomPrimitiveData(Pointer, MemoryOwner);
		}

		// Token: 0x04004198 RID: 16792
		public const string __ObjectPath = "/Script/Engine.CustomPrimitiveData";

		// Token: 0x04004199 RID: 16793
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400419A RID: 16794
		internal static int __PropertyOffset_Data;

		// Token: 0x0400419B RID: 16795
		[Nullable(2)]
		private TArray<float> _Data;
	}
}
