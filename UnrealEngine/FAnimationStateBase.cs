using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007E6 RID: 2022
	[UnrealObjectPath("/Script/Engine.AnimationStateBase")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FAnimationStateBase : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006BCA RID: 27594 RVA: 0x0009B136 File Offset: 0x00099336
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimationStateBase._ScriptStructPtr != 0) ? FAnimationStateBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimationStateBase", ref FAnimationStateBase._ScriptStructPtr);
		}

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x06006BCB RID: 27595 RVA: 0x0009B15A File Offset: 0x0009935A
		// (set) Token: 0x06006BCC RID: 27596 RVA: 0x0009B16E File Offset: 0x0009936E
		public unsafe FName StateName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationStateBase.__PropertyOffset_StateName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationStateBase.__PropertyOffset_StateName) = value;
			}
		}

		// Token: 0x06006BCD RID: 27597 RVA: 0x0009B183 File Offset: 0x00099383
		public FAnimationStateBase()
		{
		}

		// Token: 0x06006BCE RID: 27598 RVA: 0x0009B18B File Offset: 0x0009938B
		public FAnimationStateBase(FName StateName)
		{
			this.StateName = StateName;
		}

		// Token: 0x06006BCF RID: 27599 RVA: 0x0009B19A File Offset: 0x0009939A
		protected override IntPtr GetUStructPtr()
		{
			return FAnimationStateBase.StaticStruct();
		}

		// Token: 0x06006BD0 RID: 27600 RVA: 0x0009B1A6 File Offset: 0x000993A6
		[NullableContext(2)]
		public FAnimationStateBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006BD1 RID: 27601 RVA: 0x0009B1B0 File Offset: 0x000993B0
		public FAnimationStateBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006BD2 RID: 27602 RVA: 0x0009B1BB File Offset: 0x000993BB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimationStateBase(Pointer, false, true);
		}

		// Token: 0x06006BD3 RID: 27603 RVA: 0x0009B1C5 File Offset: 0x000993C5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimationStateBase(Pointer, MemoryOwner);
		}

		// Token: 0x040033DF RID: 13279
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimationStateBase";

		// Token: 0x040033E0 RID: 13280
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040033E1 RID: 13281
		internal static int __PropertyOffset_StateName;
	}
}
