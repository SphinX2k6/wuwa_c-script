using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001627 RID: 5671
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.BoneBlock")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FBoneBlock : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601484E RID: 84046 RVA: 0x001E2F73 File Offset: 0x001E1173
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoneBlock._ScriptStructPtr != 0) ? FBoneBlock._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.BoneBlock", ref FBoneBlock._ScriptStructPtr);
		}

		// Token: 0x170050CD RID: 20685
		// (get) Token: 0x0601484F RID: 84047 RVA: 0x001E2F98 File Offset: 0x001E1198
		// (set) Token: 0x06014850 RID: 84048 RVA: 0x001E2FDB File Offset: 0x001E11DB
		public TArray<FName> Groups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Groups) == null)
				{
					result = (this._Groups = new TArray<FName>(base.NativePtr + (IntPtr)FBoneBlock.__PropertyOffset_Groups, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Groups.CopyAssign(value);
			}
		}

		// Token: 0x170050CE RID: 20686
		// (get) Token: 0x06014851 RID: 84049 RVA: 0x001E2FEC File Offset: 0x001E11EC
		// (set) Token: 0x06014852 RID: 84050 RVA: 0x001E302F File Offset: 0x001E122F
		public TMap<int, float> Link
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, float> result;
				if ((result = this._Link) == null)
				{
					result = (this._Link = new TMap<int, float>(base.NativePtr + (IntPtr)FBoneBlock.__PropertyOffset_Link, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Link.CopyAssign(value);
			}
		}

		// Token: 0x06014853 RID: 84051 RVA: 0x001E303D File Offset: 0x001E123D
		public FBoneBlock()
		{
		}

		// Token: 0x06014854 RID: 84052 RVA: 0x001E3045 File Offset: 0x001E1245
		public FBoneBlock(TArray<FName> Groups, TMap<int, float> Link)
		{
			this.Groups = Groups;
			this.Link = Link;
		}

		// Token: 0x06014855 RID: 84053 RVA: 0x001E305B File Offset: 0x001E125B
		protected override IntPtr GetUStructPtr()
		{
			return FBoneBlock.StaticStruct();
		}

		// Token: 0x06014856 RID: 84054 RVA: 0x001E3067 File Offset: 0x001E1267
		[NullableContext(2)]
		public FBoneBlock(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014857 RID: 84055 RVA: 0x001E3071 File Offset: 0x001E1271
		public FBoneBlock(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014858 RID: 84056 RVA: 0x001E307C File Offset: 0x001E127C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoneBlock(Pointer, false, true);
		}

		// Token: 0x06014859 RID: 84057 RVA: 0x001E3086 File Offset: 0x001E1286
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoneBlock(Pointer, MemoryOwner);
		}

		// Token: 0x0400B28A RID: 45706
		public const string __ObjectPath = "/Script/KuroAnim.BoneBlock";

		// Token: 0x0400B28B RID: 45707
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B28C RID: 45708
		internal static int __PropertyOffset_Groups;

		// Token: 0x0400B28D RID: 45709
		[Nullable(2)]
		private TArray<FName> _Groups;

		// Token: 0x0400B28E RID: 45710
		internal static int __PropertyOffset_Link;

		// Token: 0x0400B28F RID: 45711
		[Nullable(2)]
		private TMap<int, float> _Link;
	}
}
