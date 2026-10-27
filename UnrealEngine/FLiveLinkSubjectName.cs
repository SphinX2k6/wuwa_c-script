using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200221B RID: 8731
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkSubjectName")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FLiveLinkSubjectName : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021409 RID: 136201 RVA: 0x003104B2 File Offset: 0x0030E6B2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkSubjectName._ScriptStructPtr != 0) ? FLiveLinkSubjectName._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkSubjectName", ref FLiveLinkSubjectName._ScriptStructPtr);
		}

		// Token: 0x170081CB RID: 33227
		// (get) Token: 0x0602140A RID: 136202 RVA: 0x003104D6 File Offset: 0x0030E6D6
		// (set) Token: 0x0602140B RID: 136203 RVA: 0x003104EA File Offset: 0x0030E6EA
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSubjectName.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSubjectName.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x0602140C RID: 136204 RVA: 0x003104FF File Offset: 0x0030E6FF
		public FLiveLinkSubjectName()
		{
		}

		// Token: 0x0602140D RID: 136205 RVA: 0x00310507 File Offset: 0x0030E707
		public FLiveLinkSubjectName(FName Name)
		{
			this.Name = Name;
		}

		// Token: 0x0602140E RID: 136206 RVA: 0x00310516 File Offset: 0x0030E716
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkSubjectName.StaticStruct();
		}

		// Token: 0x0602140F RID: 136207 RVA: 0x00310522 File Offset: 0x0030E722
		[NullableContext(2)]
		public FLiveLinkSubjectName(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021410 RID: 136208 RVA: 0x0031052C File Offset: 0x0030E72C
		public FLiveLinkSubjectName(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021411 RID: 136209 RVA: 0x00310537 File Offset: 0x0030E737
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkSubjectName(Pointer, false, true);
		}

		// Token: 0x06021412 RID: 136210 RVA: 0x00310541 File Offset: 0x0030E741
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkSubjectName(Pointer, MemoryOwner);
		}

		// Token: 0x04011BC9 RID: 72649
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkSubjectName";

		// Token: 0x04011BCA RID: 72650
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011BCB RID: 72651
		internal static int __PropertyOffset_Name;
	}
}
