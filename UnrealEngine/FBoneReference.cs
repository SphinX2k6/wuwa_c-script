using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008DC RID: 2268
	[UnrealObjectPath("/Script/Engine.BoneReference")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FBoneReference : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007CAE RID: 31918 RVA: 0x000B2CB4 File Offset: 0x000B0EB4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoneReference._ScriptStructPtr != 0) ? FBoneReference._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BoneReference", ref FBoneReference._ScriptStructPtr);
		}

		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x06007CAF RID: 31919 RVA: 0x000B2CD8 File Offset: 0x000B0ED8
		// (set) Token: 0x06007CB0 RID: 31920 RVA: 0x000B2CEC File Offset: 0x000B0EEC
		public unsafe FName BoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneReference.__PropertyOffset_BoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneReference.__PropertyOffset_BoneName) = value;
			}
		}

		// Token: 0x06007CB1 RID: 31921 RVA: 0x000B2D01 File Offset: 0x000B0F01
		public FBoneReference()
		{
		}

		// Token: 0x06007CB2 RID: 31922 RVA: 0x000B2D09 File Offset: 0x000B0F09
		public FBoneReference(FName BoneName)
		{
			this.BoneName = BoneName;
		}

		// Token: 0x06007CB3 RID: 31923 RVA: 0x000B2D18 File Offset: 0x000B0F18
		protected override IntPtr GetUStructPtr()
		{
			return FBoneReference.StaticStruct();
		}

		// Token: 0x06007CB4 RID: 31924 RVA: 0x000B2D24 File Offset: 0x000B0F24
		[NullableContext(2)]
		public FBoneReference(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007CB5 RID: 31925 RVA: 0x000B2D2E File Offset: 0x000B0F2E
		public FBoneReference(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007CB6 RID: 31926 RVA: 0x000B2D39 File Offset: 0x000B0F39
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoneReference(Pointer, false, true);
		}

		// Token: 0x06007CB7 RID: 31927 RVA: 0x000B2D43 File Offset: 0x000B0F43
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoneReference(Pointer, MemoryOwner);
		}

		// Token: 0x04003BC1 RID: 15297
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BoneReference";

		// Token: 0x04003BC2 RID: 15298
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003BC3 RID: 15299
		internal static int __PropertyOffset_BoneName;
	}
}
