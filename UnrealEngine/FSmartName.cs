using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200111C RID: 4380
	[UnrealObjectPath("/Script/Engine.SmartName")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSmartName : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FFFF RID: 65535 RVA: 0x00178FF2 File Offset: 0x001771F2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSmartName._ScriptStructPtr != 0) ? FSmartName._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SmartName", ref FSmartName._ScriptStructPtr);
		}

		// Token: 0x17003E78 RID: 15992
		// (get) Token: 0x06010000 RID: 65536 RVA: 0x00179016 File Offset: 0x00177216
		// (set) Token: 0x06010001 RID: 65537 RVA: 0x0017902A File Offset: 0x0017722A
		public unsafe FName DisplayName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSmartName.__PropertyOffset_DisplayName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSmartName.__PropertyOffset_DisplayName) = value;
			}
		}

		// Token: 0x06010002 RID: 65538 RVA: 0x0017903F File Offset: 0x0017723F
		public FSmartName()
		{
		}

		// Token: 0x06010003 RID: 65539 RVA: 0x00179047 File Offset: 0x00177247
		public FSmartName(FName DisplayName)
		{
			this.DisplayName = DisplayName;
		}

		// Token: 0x06010004 RID: 65540 RVA: 0x00179056 File Offset: 0x00177256
		protected override IntPtr GetUStructPtr()
		{
			return FSmartName.StaticStruct();
		}

		// Token: 0x06010005 RID: 65541 RVA: 0x00179062 File Offset: 0x00177262
		[NullableContext(2)]
		public FSmartName(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010006 RID: 65542 RVA: 0x0017906C File Offset: 0x0017726C
		public FSmartName(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010007 RID: 65543 RVA: 0x00179077 File Offset: 0x00177277
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSmartName(Pointer, false, true);
		}

		// Token: 0x06010008 RID: 65544 RVA: 0x00179081 File Offset: 0x00177281
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSmartName(Pointer, MemoryOwner);
		}

		// Token: 0x0400898D RID: 35213
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SmartName";

		// Token: 0x0400898E RID: 35214
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400898F RID: 35215
		internal static int __PropertyOffset_DisplayName;
	}
}
