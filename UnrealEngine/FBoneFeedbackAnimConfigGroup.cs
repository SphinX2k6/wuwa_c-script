using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001629 RID: 5673
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.BoneFeedbackAnimConfigGroup")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FBoneFeedbackAnimConfigGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014874 RID: 84084 RVA: 0x001E3384 File Offset: 0x001E1584
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoneFeedbackAnimConfigGroup._ScriptStructPtr != 0) ? FBoneFeedbackAnimConfigGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.BoneFeedbackAnimConfigGroup", ref FBoneFeedbackAnimConfigGroup._ScriptStructPtr);
		}

		// Token: 0x170050D8 RID: 20696
		// (get) Token: 0x06014875 RID: 84085 RVA: 0x001E33A8 File Offset: 0x001E15A8
		// (set) Token: 0x06014876 RID: 84086 RVA: 0x001E33EB File Offset: 0x001E15EB
		public TArray<FBoneFeedbackAnimConfig> Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneFeedbackAnimConfig> result;
				if ((result = this._Array) == null)
				{
					result = (this._Array = new TArray<FBoneFeedbackAnimConfig>(base.NativePtr + (IntPtr)FBoneFeedbackAnimConfigGroup.__PropertyOffset_Array, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Array.CopyAssign(value);
			}
		}

		// Token: 0x06014877 RID: 84087 RVA: 0x001E33F9 File Offset: 0x001E15F9
		public FBoneFeedbackAnimConfigGroup()
		{
		}

		// Token: 0x06014878 RID: 84088 RVA: 0x001E3401 File Offset: 0x001E1601
		public FBoneFeedbackAnimConfigGroup(TArray<FBoneFeedbackAnimConfig> Array)
		{
			this.Array = Array;
		}

		// Token: 0x06014879 RID: 84089 RVA: 0x001E3410 File Offset: 0x001E1610
		protected override IntPtr GetUStructPtr()
		{
			return FBoneFeedbackAnimConfigGroup.StaticStruct();
		}

		// Token: 0x0601487A RID: 84090 RVA: 0x001E341C File Offset: 0x001E161C
		[NullableContext(2)]
		public FBoneFeedbackAnimConfigGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601487B RID: 84091 RVA: 0x001E3426 File Offset: 0x001E1626
		public FBoneFeedbackAnimConfigGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601487C RID: 84092 RVA: 0x001E3431 File Offset: 0x001E1631
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoneFeedbackAnimConfigGroup(Pointer, false, true);
		}

		// Token: 0x0601487D RID: 84093 RVA: 0x001E343B File Offset: 0x001E163B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoneFeedbackAnimConfigGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0400B2A0 RID: 45728
		public const string __ObjectPath = "/Script/KuroAnim.BoneFeedbackAnimConfigGroup";

		// Token: 0x0400B2A1 RID: 45729
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B2A2 RID: 45730
		internal static int __PropertyOffset_Array;

		// Token: 0x0400B2A3 RID: 45731
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneFeedbackAnimConfig> _Array;
	}
}
