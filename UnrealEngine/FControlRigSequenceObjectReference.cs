using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004CF RID: 1231
	[UnrealObjectPath("/Script/ControlRig.ControlRigSequenceObjectReference")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FControlRigSequenceObjectReference : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004234 RID: 16948 RVA: 0x00062FF3 File Offset: 0x000611F3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FControlRigSequenceObjectReference._ScriptStructPtr != 0) ? FControlRigSequenceObjectReference._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ControlRigSequenceObjectReference", ref FControlRigSequenceObjectReference._ScriptStructPtr);
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x06004235 RID: 16949 RVA: 0x00063017 File Offset: 0x00061217
		// (set) Token: 0x06004236 RID: 16950 RVA: 0x0006302B File Offset: 0x0006122B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UControlRig> ControlRigClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigSequenceObjectReference.__PropertyOffset_ControlRigClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigSequenceObjectReference.__PropertyOffset_ControlRigClass) = value;
			}
		}

		// Token: 0x06004237 RID: 16951 RVA: 0x00063040 File Offset: 0x00061240
		public FControlRigSequenceObjectReference()
		{
		}

		// Token: 0x06004238 RID: 16952 RVA: 0x00063048 File Offset: 0x00061248
		public FControlRigSequenceObjectReference([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UControlRig> ControlRigClass)
		{
			this.ControlRigClass = ControlRigClass;
		}

		// Token: 0x06004239 RID: 16953 RVA: 0x00063057 File Offset: 0x00061257
		protected override IntPtr GetUStructPtr()
		{
			return FControlRigSequenceObjectReference.StaticStruct();
		}

		// Token: 0x0600423A RID: 16954 RVA: 0x00063063 File Offset: 0x00061263
		[NullableContext(2)]
		public FControlRigSequenceObjectReference(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600423B RID: 16955 RVA: 0x0006306D File Offset: 0x0006126D
		public FControlRigSequenceObjectReference(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600423C RID: 16956 RVA: 0x00063078 File Offset: 0x00061278
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FControlRigSequenceObjectReference(Pointer, false, true);
		}

		// Token: 0x0600423D RID: 16957 RVA: 0x00063082 File Offset: 0x00061282
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FControlRigSequenceObjectReference(Pointer, MemoryOwner);
		}

		// Token: 0x04001F79 RID: 8057
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.ControlRigSequenceObjectReference";

		// Token: 0x04001F7A RID: 8058
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001F7B RID: 8059
		internal static int __PropertyOffset_ControlRigClass;
	}
}
