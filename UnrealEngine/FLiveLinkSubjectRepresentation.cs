using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200221D RID: 8733
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkSubjectRepresentation")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FLiveLinkSubjectRepresentation : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021425 RID: 136229 RVA: 0x003106D9 File Offset: 0x0030E8D9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkSubjectRepresentation._ScriptStructPtr != 0) ? FLiveLinkSubjectRepresentation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkSubjectRepresentation", ref FLiveLinkSubjectRepresentation._ScriptStructPtr);
		}

		// Token: 0x170081D1 RID: 33233
		// (get) Token: 0x06021426 RID: 136230 RVA: 0x00310700 File Offset: 0x0030E900
		// (set) Token: 0x06021427 RID: 136231 RVA: 0x00310743 File Offset: 0x0030E943
		public FLiveLinkSubjectName Subject
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkSubjectName result;
				if ((result = this._Subject) == null)
				{
					result = (this._Subject = new FLiveLinkSubjectName(base.NativePtr + (IntPtr)FLiveLinkSubjectRepresentation.__PropertyOffset_Subject, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkSubjectName.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkSubjectRepresentation.__PropertyOffset_Subject, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170081D2 RID: 33234
		// (get) Token: 0x06021428 RID: 136232 RVA: 0x00310764 File Offset: 0x0030E964
		// (set) Token: 0x06021429 RID: 136233 RVA: 0x00310778 File Offset: 0x0030E978
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<ULiveLinkRole> Role
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSubjectRepresentation.__PropertyOffset_Role);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSubjectRepresentation.__PropertyOffset_Role) = value;
			}
		}

		// Token: 0x0602142A RID: 136234 RVA: 0x0031078D File Offset: 0x0030E98D
		public FLiveLinkSubjectRepresentation()
		{
		}

		// Token: 0x0602142B RID: 136235 RVA: 0x00310795 File Offset: 0x0030E995
		public FLiveLinkSubjectRepresentation(FLiveLinkSubjectName Subject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<ULiveLinkRole> Role)
		{
			this.Subject = Subject;
			this.Role = Role;
		}

		// Token: 0x0602142C RID: 136236 RVA: 0x003107AB File Offset: 0x0030E9AB
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkSubjectRepresentation.StaticStruct();
		}

		// Token: 0x0602142D RID: 136237 RVA: 0x003107B7 File Offset: 0x0030E9B7
		[NullableContext(2)]
		public FLiveLinkSubjectRepresentation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602142E RID: 136238 RVA: 0x003107C1 File Offset: 0x0030E9C1
		public FLiveLinkSubjectRepresentation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602142F RID: 136239 RVA: 0x003107CC File Offset: 0x0030E9CC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkSubjectRepresentation(Pointer, false, true);
		}

		// Token: 0x06021430 RID: 136240 RVA: 0x003107D6 File Offset: 0x0030E9D6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkSubjectRepresentation(Pointer, MemoryOwner);
		}

		// Token: 0x04011BD4 RID: 72660
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkSubjectRepresentation";

		// Token: 0x04011BD5 RID: 72661
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011BD6 RID: 72662
		internal static int __PropertyOffset_Subject;

		// Token: 0x04011BD7 RID: 72663
		[Nullable(2)]
		private FLiveLinkSubjectName _Subject;

		// Token: 0x04011BD8 RID: 72664
		internal static int __PropertyOffset_Role;
	}
}
