using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200253F RID: 9535
	[UnrealObjectPath("/Script/Niagara.NiagaraBool")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FNiagaraBool : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602363C RID: 144956 RVA: 0x003455ED File Offset: 0x003437ED
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraBool._ScriptStructPtr != 0) ? FNiagaraBool._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraBool", ref FNiagaraBool._ScriptStructPtr);
		}

		// Token: 0x17008804 RID: 34820
		// (get) Token: 0x0602363D RID: 144957 RVA: 0x00345611 File Offset: 0x00343811
		// (set) Token: 0x0602363E RID: 144958 RVA: 0x00345621 File Offset: 0x00343821
		public unsafe int Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraBool.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraBool.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x0602363F RID: 144959 RVA: 0x00345632 File Offset: 0x00343832
		public FNiagaraBool()
		{
		}

		// Token: 0x06023640 RID: 144960 RVA: 0x0034563A File Offset: 0x0034383A
		public FNiagaraBool(int Value)
		{
			this.Value = Value;
		}

		// Token: 0x06023641 RID: 144961 RVA: 0x00345649 File Offset: 0x00343849
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraBool.StaticStruct();
		}

		// Token: 0x06023642 RID: 144962 RVA: 0x00345655 File Offset: 0x00343855
		[NullableContext(2)]
		public FNiagaraBool(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023643 RID: 144963 RVA: 0x0034565F File Offset: 0x0034385F
		public FNiagaraBool(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023644 RID: 144964 RVA: 0x0034566A File Offset: 0x0034386A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraBool(Pointer, false, true);
		}

		// Token: 0x06023645 RID: 144965 RVA: 0x00345674 File Offset: 0x00343874
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraBool(Pointer, MemoryOwner);
		}

		// Token: 0x04012FE7 RID: 77799
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraBool";

		// Token: 0x04012FE8 RID: 77800
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012FE9 RID: 77801
		internal static int __PropertyOffset_Value;
	}
}
