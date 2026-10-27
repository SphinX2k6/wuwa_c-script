using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200116C RID: 4460
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SpecialPathCheck")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSpecialPathCheck : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060104D6 RID: 66774 RVA: 0x001803DE File Offset: 0x0017E5DE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpecialPathCheck._ScriptStructPtr != 0) ? FSpecialPathCheck._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SpecialPathCheck", ref FSpecialPathCheck._ScriptStructPtr);
		}

		// Token: 0x17003FE4 RID: 16356
		// (get) Token: 0x060104D7 RID: 66775 RVA: 0x00180404 File Offset: 0x0017E604
		// (set) Token: 0x060104D8 RID: 66776 RVA: 0x00180447 File Offset: 0x0017E647
		public TArray<string> None
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._None) == null)
				{
					result = (this._None = new TArray<string>(base.NativePtr + (IntPtr)FSpecialPathCheck.__PropertyOffset_None, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.None.CopyAssign(value);
			}
		}

		// Token: 0x060104D9 RID: 66777 RVA: 0x00180455 File Offset: 0x0017E655
		public FSpecialPathCheck()
		{
		}

		// Token: 0x060104DA RID: 66778 RVA: 0x0018045D File Offset: 0x0017E65D
		public FSpecialPathCheck(TArray<string> None)
		{
			this.None = None;
		}

		// Token: 0x060104DB RID: 66779 RVA: 0x0018046C File Offset: 0x0017E66C
		protected override IntPtr GetUStructPtr()
		{
			return FSpecialPathCheck.StaticStruct();
		}

		// Token: 0x060104DC RID: 66780 RVA: 0x00180478 File Offset: 0x0017E678
		[NullableContext(2)]
		public FSpecialPathCheck(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060104DD RID: 66781 RVA: 0x00180482 File Offset: 0x0017E682
		public FSpecialPathCheck(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060104DE RID: 66782 RVA: 0x0018048D File Offset: 0x0017E68D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpecialPathCheck(Pointer, false, true);
		}

		// Token: 0x060104DF RID: 66783 RVA: 0x00180497 File Offset: 0x0017E697
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpecialPathCheck(Pointer, MemoryOwner);
		}

		// Token: 0x04008C4B RID: 35915
		public const string __ObjectPath = "/Script/Engine.SpecialPathCheck";

		// Token: 0x04008C4C RID: 35916
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008C4D RID: 35917
		internal static int __PropertyOffset_None;

		// Token: 0x04008C4E RID: 35918
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _None;
	}
}
