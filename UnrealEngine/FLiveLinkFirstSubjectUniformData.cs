using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002201 RID: 8705
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkFirstSubjectUniformData")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FLiveLinkFirstSubjectUniformData : FLiveLinkBaseUniformData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060212BD RID: 135869 RVA: 0x0030E871 File Offset: 0x0030CA71
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkFirstSubjectUniformData._ScriptStructPtr != 0) ? FLiveLinkFirstSubjectUniformData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkFirstSubjectUniformData", ref FLiveLinkFirstSubjectUniformData._ScriptStructPtr);
		}

		// Token: 0x1700817E RID: 33150
		// (get) Token: 0x060212BE RID: 135870 RVA: 0x0030E895 File Offset: 0x0030CA95
		// (set) Token: 0x060212BF RID: 135871 RVA: 0x0030E8A5 File Offset: 0x0030CAA5
		public unsafe int SelectedIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkFirstSubjectUniformData.__PropertyOffset_SelectedIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkFirstSubjectUniformData.__PropertyOffset_SelectedIndex) = value;
			}
		}

		// Token: 0x1700817F RID: 33151
		// (get) Token: 0x060212C0 RID: 135872 RVA: 0x0030E8B6 File Offset: 0x0030CAB6
		// (set) Token: 0x060212C1 RID: 135873 RVA: 0x0030E8CA File Offset: 0x0030CACA
		public unsafe string SubjectName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLiveLinkFirstSubjectUniformData.__PropertyOffset_SubjectName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLiveLinkFirstSubjectUniformData.__PropertyOffset_SubjectName)), value);
			}
		}

		// Token: 0x060212C2 RID: 135874 RVA: 0x0030E8DF File Offset: 0x0030CADF
		public FLiveLinkFirstSubjectUniformData()
		{
		}

		// Token: 0x060212C3 RID: 135875 RVA: 0x0030E8E7 File Offset: 0x0030CAE7
		public FLiveLinkFirstSubjectUniformData(int SelectedIndex, string SubjectName)
		{
			this.SelectedIndex = SelectedIndex;
			this.SubjectName = SubjectName;
		}

		// Token: 0x060212C4 RID: 135876 RVA: 0x0030E8FD File Offset: 0x0030CAFD
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkFirstSubjectUniformData.StaticStruct();
		}

		// Token: 0x060212C5 RID: 135877 RVA: 0x0030E909 File Offset: 0x0030CB09
		[NullableContext(2)]
		public FLiveLinkFirstSubjectUniformData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060212C6 RID: 135878 RVA: 0x0030E913 File Offset: 0x0030CB13
		public FLiveLinkFirstSubjectUniformData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060212C7 RID: 135879 RVA: 0x0030E91E File Offset: 0x0030CB1E
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkFirstSubjectUniformData(Pointer, false, true);
		}

		// Token: 0x060212C8 RID: 135880 RVA: 0x0030E928 File Offset: 0x0030CB28
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkFirstSubjectUniformData(Pointer, MemoryOwner);
		}

		// Token: 0x04011B2A RID: 72490
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkFirstSubjectUniformData";

		// Token: 0x04011B2B RID: 72491
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011B2C RID: 72492
		internal static int __PropertyOffset_SelectedIndex;

		// Token: 0x04011B2D RID: 72493
		internal static int __PropertyOffset_SubjectName;
	}
}
