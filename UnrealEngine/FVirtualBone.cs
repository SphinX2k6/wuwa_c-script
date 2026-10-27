using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200122F RID: 4655
	[UnrealObjectPath("/Script/Engine.VirtualBone")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FVirtualBone : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060111F2 RID: 70130 RVA: 0x00191FC3 File Offset: 0x001901C3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVirtualBone._ScriptStructPtr != 0) ? FVirtualBone._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.VirtualBone", ref FVirtualBone._ScriptStructPtr);
		}

		// Token: 0x170042D0 RID: 17104
		// (get) Token: 0x060111F3 RID: 70131 RVA: 0x00191FE7 File Offset: 0x001901E7
		// (set) Token: 0x060111F4 RID: 70132 RVA: 0x00191FFB File Offset: 0x001901FB
		public unsafe FName SourceBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVirtualBone.__PropertyOffset_SourceBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVirtualBone.__PropertyOffset_SourceBoneName) = value;
			}
		}

		// Token: 0x170042D1 RID: 17105
		// (get) Token: 0x060111F5 RID: 70133 RVA: 0x00192010 File Offset: 0x00190210
		// (set) Token: 0x060111F6 RID: 70134 RVA: 0x00192024 File Offset: 0x00190224
		public unsafe FName TargetBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVirtualBone.__PropertyOffset_TargetBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVirtualBone.__PropertyOffset_TargetBoneName) = value;
			}
		}

		// Token: 0x170042D2 RID: 17106
		// (get) Token: 0x060111F7 RID: 70135 RVA: 0x00192039 File Offset: 0x00190239
		// (set) Token: 0x060111F8 RID: 70136 RVA: 0x0019204D File Offset: 0x0019024D
		public unsafe FName VirtualBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVirtualBone.__PropertyOffset_VirtualBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVirtualBone.__PropertyOffset_VirtualBoneName) = value;
			}
		}

		// Token: 0x060111F9 RID: 70137 RVA: 0x00192062 File Offset: 0x00190262
		public FVirtualBone()
		{
		}

		// Token: 0x060111FA RID: 70138 RVA: 0x0019206A File Offset: 0x0019026A
		public FVirtualBone(FName SourceBoneName, FName TargetBoneName, FName VirtualBoneName)
		{
			this.SourceBoneName = SourceBoneName;
			this.TargetBoneName = TargetBoneName;
			this.VirtualBoneName = VirtualBoneName;
		}

		// Token: 0x060111FB RID: 70139 RVA: 0x00192087 File Offset: 0x00190287
		protected override IntPtr GetUStructPtr()
		{
			return FVirtualBone.StaticStruct();
		}

		// Token: 0x060111FC RID: 70140 RVA: 0x00192093 File Offset: 0x00190293
		[NullableContext(2)]
		public FVirtualBone(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060111FD RID: 70141 RVA: 0x0019209D File Offset: 0x0019029D
		public FVirtualBone(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060111FE RID: 70142 RVA: 0x001920A8 File Offset: 0x001902A8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVirtualBone(Pointer, false, true);
		}

		// Token: 0x060111FF RID: 70143 RVA: 0x001920B2 File Offset: 0x001902B2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVirtualBone(Pointer, MemoryOwner);
		}

		// Token: 0x0400929B RID: 37531
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.VirtualBone";

		// Token: 0x0400929C RID: 37532
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400929D RID: 37533
		internal static int __PropertyOffset_SourceBoneName;

		// Token: 0x0400929E RID: 37534
		internal static int __PropertyOffset_TargetBoneName;

		// Token: 0x0400929F RID: 37535
		internal static int __PropertyOffset_VirtualBoneName;
	}
}
