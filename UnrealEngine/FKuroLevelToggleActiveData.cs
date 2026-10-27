using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019BA RID: 6586
	[UnrealObjectPath("/Script/KuroLevelStateMachine.KuroLevelToggleActiveData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroLevelToggleActiveData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060187E9 RID: 100329 RVA: 0x002417CA File Offset: 0x0023F9CA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLevelToggleActiveData._ScriptStructPtr != 0) ? FKuroLevelToggleActiveData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroLevelStateMachine.KuroLevelToggleActiveData", ref FKuroLevelToggleActiveData._ScriptStructPtr);
		}

		// Token: 0x170061CA RID: 25034
		// (get) Token: 0x060187EA RID: 100330 RVA: 0x002417EE File Offset: 0x0023F9EE
		// (set) Token: 0x060187EB RID: 100331 RVA: 0x00241802 File Offset: 0x0023FA02
		[Nullable(2)]
		public unsafe AActor Actor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroLevelToggleActiveData.__PropertyOffset_Actor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroLevelToggleActiveData.__PropertyOffset_Actor, value);
			}
		}

		// Token: 0x170061CB RID: 25035
		// (get) Token: 0x060187EC RID: 100332 RVA: 0x00241817 File Offset: 0x0023FA17
		// (set) Token: 0x060187ED RID: 100333 RVA: 0x00241827 File Offset: 0x0023FA27
		public unsafe bool bIncludeChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelToggleActiveData.__PropertyOffset_bIncludeChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelToggleActiveData.__PropertyOffset_bIncludeChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061CC RID: 25036
		// (get) Token: 0x060187EE RID: 100334 RVA: 0x00241838 File Offset: 0x0023FA38
		// (set) Token: 0x060187EF RID: 100335 RVA: 0x00241848 File Offset: 0x0023FA48
		public unsafe bool bEnterActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelToggleActiveData.__PropertyOffset_bEnterActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelToggleActiveData.__PropertyOffset_bEnterActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061CD RID: 25037
		// (get) Token: 0x060187F0 RID: 100336 RVA: 0x00241859 File Offset: 0x0023FA59
		// (set) Token: 0x060187F1 RID: 100337 RVA: 0x00241869 File Offset: 0x0023FA69
		public unsafe bool bEnterCollisionEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelToggleActiveData.__PropertyOffset_bEnterCollisionEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelToggleActiveData.__PropertyOffset_bEnterCollisionEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061CE RID: 25038
		// (get) Token: 0x060187F2 RID: 100338 RVA: 0x0024187A File Offset: 0x0023FA7A
		// (set) Token: 0x060187F3 RID: 100339 RVA: 0x0024188A File Offset: 0x0023FA8A
		public unsafe bool bExitReverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelToggleActiveData.__PropertyOffset_bExitReverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelToggleActiveData.__PropertyOffset_bExitReverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061CF RID: 25039
		// (get) Token: 0x060187F4 RID: 100340 RVA: 0x0024189B File Offset: 0x0023FA9B
		// (set) Token: 0x060187F5 RID: 100341 RVA: 0x002418AB File Offset: 0x0023FAAB
		public unsafe bool bExitActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelToggleActiveData.__PropertyOffset_bExitActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelToggleActiveData.__PropertyOffset_bExitActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061D0 RID: 25040
		// (get) Token: 0x060187F6 RID: 100342 RVA: 0x002418BC File Offset: 0x0023FABC
		// (set) Token: 0x060187F7 RID: 100343 RVA: 0x002418CC File Offset: 0x0023FACC
		public unsafe bool bExitCollisionEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelToggleActiveData.__PropertyOffset_bExitCollisionEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelToggleActiveData.__PropertyOffset_bExitCollisionEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x060187F8 RID: 100344 RVA: 0x002418DD File Offset: 0x0023FADD
		public FKuroLevelToggleActiveData()
		{
		}

		// Token: 0x060187F9 RID: 100345 RVA: 0x002418E5 File Offset: 0x0023FAE5
		[NullableContext(1)]
		public FKuroLevelToggleActiveData(AActor Actor, bool bIncludeChildren, bool bEnterActive, bool bEnterCollisionEnable, bool bExitReverse, bool bExitActive, bool bExitCollisionEnable)
		{
			this.Actor = Actor;
			this.bIncludeChildren = bIncludeChildren;
			this.bEnterActive = bEnterActive;
			this.bEnterCollisionEnable = bEnterCollisionEnable;
			this.bExitReverse = bExitReverse;
			this.bExitActive = bExitActive;
			this.bExitCollisionEnable = bExitCollisionEnable;
		}

		// Token: 0x060187FA RID: 100346 RVA: 0x00241922 File Offset: 0x0023FB22
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLevelToggleActiveData.StaticStruct();
		}

		// Token: 0x060187FB RID: 100347 RVA: 0x0024192E File Offset: 0x0023FB2E
		[NullableContext(2)]
		public FKuroLevelToggleActiveData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060187FC RID: 100348 RVA: 0x00241938 File Offset: 0x0023FB38
		public FKuroLevelToggleActiveData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060187FD RID: 100349 RVA: 0x00241943 File Offset: 0x0023FB43
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLevelToggleActiveData(Pointer, false, true);
		}

		// Token: 0x060187FE RID: 100350 RVA: 0x0024194D File Offset: 0x0023FB4D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLevelToggleActiveData(Pointer, MemoryOwner);
		}

		// Token: 0x0400D3B3 RID: 54195
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroLevelStateMachine.KuroLevelToggleActiveData";

		// Token: 0x0400D3B4 RID: 54196
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D3B5 RID: 54197
		internal static int __PropertyOffset_Actor;

		// Token: 0x0400D3B6 RID: 54198
		internal static int __PropertyOffset_bIncludeChildren;

		// Token: 0x0400D3B7 RID: 54199
		internal static int __PropertyOffset_bEnterActive;

		// Token: 0x0400D3B8 RID: 54200
		internal static int __PropertyOffset_bEnterCollisionEnable;

		// Token: 0x0400D3B9 RID: 54201
		internal static int __PropertyOffset_bExitReverse;

		// Token: 0x0400D3BA RID: 54202
		internal static int __PropertyOffset_bExitActive;

		// Token: 0x0400D3BB RID: 54203
		internal static int __PropertyOffset_bExitCollisionEnable;
	}
}
