using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000343 RID: 835
	[UnrealObjectPath("/Script/AnimGraphRuntime.SocketReference")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FSocketReference : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002EAA RID: 11946 RVA: 0x0004773C File Offset: 0x0004593C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSocketReference._ScriptStructPtr != 0) ? FSocketReference._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.SocketReference", ref FSocketReference._ScriptStructPtr);
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06002EAB RID: 11947 RVA: 0x00047760 File Offset: 0x00045960
		// (set) Token: 0x06002EAC RID: 11948 RVA: 0x00047774 File Offset: 0x00045974
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSocketReference.__PropertyOffset_SocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSocketReference.__PropertyOffset_SocketName) = value;
			}
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x00047789 File Offset: 0x00045989
		public FSocketReference()
		{
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x00047791 File Offset: 0x00045991
		public FSocketReference(FName SocketName)
		{
			this.SocketName = SocketName;
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x000477A0 File Offset: 0x000459A0
		protected override IntPtr GetUStructPtr()
		{
			return FSocketReference.StaticStruct();
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x000477AC File Offset: 0x000459AC
		[NullableContext(2)]
		public FSocketReference(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x000477B6 File Offset: 0x000459B6
		public FSocketReference(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x000477C1 File Offset: 0x000459C1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSocketReference(Pointer, false, true);
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x000477CB File Offset: 0x000459CB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSocketReference(Pointer, MemoryOwner);
		}

		// Token: 0x04001401 RID: 5121
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimGraphRuntime.SocketReference";

		// Token: 0x04001402 RID: 5122
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001403 RID: 5123
		internal static int __PropertyOffset_SocketName;
	}
}
