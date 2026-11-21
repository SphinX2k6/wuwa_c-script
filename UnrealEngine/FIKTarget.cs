using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002EC RID: 748
	[UnrealObjectPath("/Script/KuroAnim.IKTarget")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FIKTarget : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004FC6 RID: 20422 RVA: 0x0006FA6F File Offset: 0x0006DC6F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIKTarget._ScriptStructPtr != 0) ? FIKTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.IKTarget", ref FIKTarget._ScriptStructPtr);
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06004FC7 RID: 20423 RVA: 0x0006FA93 File Offset: 0x0006DC93
		// (set) Token: 0x06004FC8 RID: 20424 RVA: 0x0006FAA7 File Offset: 0x0006DCA7
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIKTarget.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIKTarget.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06004FC9 RID: 20425 RVA: 0x0006FABC File Offset: 0x0006DCBC
		// (set) Token: 0x06004FCA RID: 20426 RVA: 0x0006FAD0 File Offset: 0x0006DCD0
		public unsafe FQuat Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIKTarget.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIKTarget.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06004FCB RID: 20427 RVA: 0x0006FAE5 File Offset: 0x0006DCE5
		// (set) Token: 0x06004FCC RID: 20428 RVA: 0x0006FAF5 File Offset: 0x0006DCF5
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIKTarget.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIKTarget.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x06004FCD RID: 20429 RVA: 0x0006FB06 File Offset: 0x0006DD06
		public FIKTarget()
		{
		}

		// Token: 0x06004FCE RID: 20430 RVA: 0x0006FB0E File Offset: 0x0006DD0E
		protected override IntPtr GetUStructPtr()
		{
			return FIKTarget.StaticStruct();
		}

		// Token: 0x06004FCF RID: 20431 RVA: 0x0006FB1A File Offset: 0x0006DD1A
		[NullableContext(2)]
		public FIKTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004FD0 RID: 20432 RVA: 0x0006FB24 File Offset: 0x0006DD24
		public FIKTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004FD1 RID: 20433 RVA: 0x0006FB2F File Offset: 0x0006DD2F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIKTarget(Pointer, false, true);
		}

		// Token: 0x06004FD2 RID: 20434 RVA: 0x0006FB39 File Offset: 0x0006DD39
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIKTarget(Pointer, MemoryOwner);
		}

		// Token: 0x04002074 RID: 8308
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.IKTarget";

		// Token: 0x04002075 RID: 8309
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002076 RID: 8310
		internal static int __PropertyOffset_Location;

		// Token: 0x04002077 RID: 8311
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04002078 RID: 8312
		internal static int __PropertyOffset_Alpha;
	}
}
