using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003B2 RID: 946
	[UnrealObjectPath("/Script/AugmentedReality.ARObjectUpdatePayload")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FARObjectUpdatePayload : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003466 RID: 13414 RVA: 0x000501AC File Offset: 0x0004E3AC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FARObjectUpdatePayload._ScriptStructPtr != 0) ? FARObjectUpdatePayload._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AugmentedReality.ARObjectUpdatePayload", ref FARObjectUpdatePayload._ScriptStructPtr);
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06003467 RID: 13415 RVA: 0x000501D0 File Offset: 0x0004E3D0
		// (set) Token: 0x06003468 RID: 13416 RVA: 0x000501E4 File Offset: 0x0004E3E4
		public unsafe FTransform WorldTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARObjectUpdatePayload.__PropertyOffset_WorldTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARObjectUpdatePayload.__PropertyOffset_WorldTransform) = value;
			}
		}

		// Token: 0x06003469 RID: 13417 RVA: 0x000501F9 File Offset: 0x0004E3F9
		public FARObjectUpdatePayload()
		{
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x00050201 File Offset: 0x0004E401
		public FARObjectUpdatePayload(FTransform WorldTransform)
		{
			this.WorldTransform = WorldTransform;
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x00050210 File Offset: 0x0004E410
		protected override IntPtr GetUStructPtr()
		{
			return FARObjectUpdatePayload.StaticStruct();
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x0005021C File Offset: 0x0004E41C
		[NullableContext(2)]
		public FARObjectUpdatePayload(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x00050226 File Offset: 0x0004E426
		public FARObjectUpdatePayload(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x00050231 File Offset: 0x0004E431
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FARObjectUpdatePayload(Pointer, false, true);
		}

		// Token: 0x0600346F RID: 13423 RVA: 0x0005023B File Offset: 0x0004E43B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FARObjectUpdatePayload(Pointer, MemoryOwner);
		}

		// Token: 0x040016BE RID: 5822
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.ARObjectUpdatePayload";

		// Token: 0x040016BF RID: 5823
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040016C0 RID: 5824
		internal static int __PropertyOffset_WorldTransform;
	}
}
