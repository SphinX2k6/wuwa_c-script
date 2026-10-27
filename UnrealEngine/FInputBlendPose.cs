using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C56 RID: 3158
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InputBlendPose")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FInputBlendPose : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A01A RID: 40986 RVA: 0x000E3872 File Offset: 0x000E1A72
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputBlendPose._ScriptStructPtr != 0) ? FInputBlendPose._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InputBlendPose", ref FInputBlendPose._ScriptStructPtr);
		}

		// Token: 0x17002626 RID: 9766
		// (get) Token: 0x0600A01B RID: 40987 RVA: 0x000E3898 File Offset: 0x000E1A98
		// (set) Token: 0x0600A01C RID: 40988 RVA: 0x000E38DB File Offset: 0x000E1ADB
		public TArray<FBranchFilter> BranchFilters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBranchFilter> result;
				if ((result = this._BranchFilters) == null)
				{
					result = (this._BranchFilters = new TArray<FBranchFilter>(base.NativePtr + (IntPtr)FInputBlendPose.__PropertyOffset_BranchFilters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BranchFilters.CopyAssign(value);
			}
		}

		// Token: 0x0600A01D RID: 40989 RVA: 0x000E38E9 File Offset: 0x000E1AE9
		public FInputBlendPose()
		{
		}

		// Token: 0x0600A01E RID: 40990 RVA: 0x000E38F1 File Offset: 0x000E1AF1
		public FInputBlendPose(TArray<FBranchFilter> BranchFilters)
		{
			this.BranchFilters = BranchFilters;
		}

		// Token: 0x0600A01F RID: 40991 RVA: 0x000E3900 File Offset: 0x000E1B00
		protected override IntPtr GetUStructPtr()
		{
			return FInputBlendPose.StaticStruct();
		}

		// Token: 0x0600A020 RID: 40992 RVA: 0x000E390C File Offset: 0x000E1B0C
		[NullableContext(2)]
		public FInputBlendPose(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A021 RID: 40993 RVA: 0x000E3916 File Offset: 0x000E1B16
		public FInputBlendPose(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A022 RID: 40994 RVA: 0x000E3921 File Offset: 0x000E1B21
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputBlendPose(Pointer, false, true);
		}

		// Token: 0x0600A023 RID: 40995 RVA: 0x000E392B File Offset: 0x000E1B2B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputBlendPose(Pointer, MemoryOwner);
		}

		// Token: 0x04005817 RID: 22551
		public const string __ObjectPath = "/Script/Engine.InputBlendPose";

		// Token: 0x04005818 RID: 22552
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005819 RID: 22553
		internal static int __PropertyOffset_BranchFilters;

		// Token: 0x0400581A RID: 22554
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBranchFilter> _BranchFilters;
	}
}
