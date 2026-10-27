using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200273D RID: 10045
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestStruct_BlittableFixedArray")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FSharpherealTestStruct_BlittableFixedArray : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025356 RID: 152406 RVA: 0x00372674 File Offset: 0x00370874
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealTestStruct_BlittableFixedArray._ScriptStructPtr != 0) ? FSharpherealTestStruct_BlittableFixedArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SharpherealTest.SharpherealTestStruct_BlittableFixedArray", ref FSharpherealTestStruct_BlittableFixedArray._ScriptStructPtr);
		}

		// Token: 0x17008FA4 RID: 36772
		// (get) Token: 0x06025357 RID: 152407 RVA: 0x00372698 File Offset: 0x00370898
		// (set) Token: 0x06025358 RID: 152408 RVA: 0x003726DC File Offset: 0x003708DC
		public TFixedArray<int> V
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<int> result;
				if ((result = this._V) == null)
				{
					result = (this._V = new TFixedArray<int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_BlittableFixedArray.__PropertyOffset_V, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.V.CopyAssign(value);
			}
		}

		// Token: 0x06025359 RID: 152409 RVA: 0x003726EA File Offset: 0x003708EA
		public FSharpherealTestStruct_BlittableFixedArray()
		{
		}

		// Token: 0x0602535A RID: 152410 RVA: 0x003726F2 File Offset: 0x003708F2
		public FSharpherealTestStruct_BlittableFixedArray(TFixedArray<int> V)
		{
			this.V = V;
		}

		// Token: 0x0602535B RID: 152411 RVA: 0x00372701 File Offset: 0x00370901
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealTestStruct_BlittableFixedArray.StaticStruct();
		}

		// Token: 0x0602535C RID: 152412 RVA: 0x0037270D File Offset: 0x0037090D
		[NullableContext(2)]
		public FSharpherealTestStruct_BlittableFixedArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602535D RID: 152413 RVA: 0x00372717 File Offset: 0x00370917
		public FSharpherealTestStruct_BlittableFixedArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602535E RID: 152414 RVA: 0x00372722 File Offset: 0x00370922
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealTestStruct_BlittableFixedArray(Pointer, false, true);
		}

		// Token: 0x0602535F RID: 152415 RVA: 0x0037272C File Offset: 0x0037092C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealTestStruct_BlittableFixedArray(Pointer, MemoryOwner);
		}

		// Token: 0x04014100 RID: 82176
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestStruct_BlittableFixedArray";

		// Token: 0x04014101 RID: 82177
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014102 RID: 82178
		internal static int __PropertyOffset_V;

		// Token: 0x04014103 RID: 82179
		[Nullable(2)]
		private TFixedArray<int> _V;
	}
}
