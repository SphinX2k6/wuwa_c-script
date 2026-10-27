using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019B8 RID: 6584
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroLevelStateMachine.KuroLevelSwitchCollisionData")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKuroLevelSwitchCollisionData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060187D0 RID: 100304 RVA: 0x0024153E File Offset: 0x0023F73E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLevelSwitchCollisionData._ScriptStructPtr != 0) ? FKuroLevelSwitchCollisionData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroLevelStateMachine.KuroLevelSwitchCollisionData", ref FKuroLevelSwitchCollisionData._ScriptStructPtr);
		}

		// Token: 0x170061C4 RID: 25028
		// (get) Token: 0x060187D1 RID: 100305 RVA: 0x00241562 File Offset: 0x0023F762
		// (set) Token: 0x060187D2 RID: 100306 RVA: 0x00241576 File Offset: 0x0023F776
		[Nullable(2)]
		public unsafe AActor Actor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroLevelSwitchCollisionData.__PropertyOffset_Actor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroLevelSwitchCollisionData.__PropertyOffset_Actor, value);
			}
		}

		// Token: 0x170061C5 RID: 25029
		// (get) Token: 0x060187D3 RID: 100307 RVA: 0x0024158B File Offset: 0x0023F78B
		// (set) Token: 0x060187D4 RID: 100308 RVA: 0x0024159B File Offset: 0x0023F79B
		public unsafe bool bIncludeChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelSwitchCollisionData.__PropertyOffset_bIncludeChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelSwitchCollisionData.__PropertyOffset_bIncludeChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061C6 RID: 25030
		// (get) Token: 0x060187D5 RID: 100309 RVA: 0x002415AC File Offset: 0x0023F7AC
		// (set) Token: 0x060187D6 RID: 100310 RVA: 0x002415EF File Offset: 0x0023F7EF
		public FCollisionProfileName EnterCollision
		{
			get
			{
				base.FastCheckIsValid();
				FCollisionProfileName result;
				if ((result = this._EnterCollision) == null)
				{
					result = (this._EnterCollision = new FCollisionProfileName(base.NativePtr + (IntPtr)FKuroLevelSwitchCollisionData.__PropertyOffset_EnterCollision, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionProfileName.StaticStruct(), base.NativePtr + (IntPtr)FKuroLevelSwitchCollisionData.__PropertyOffset_EnterCollision, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170061C7 RID: 25031
		// (get) Token: 0x060187D7 RID: 100311 RVA: 0x00241610 File Offset: 0x0023F810
		// (set) Token: 0x060187D8 RID: 100312 RVA: 0x00241620 File Offset: 0x0023F820
		public unsafe bool bExitReverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelSwitchCollisionData.__PropertyOffset_bExitReverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelSwitchCollisionData.__PropertyOffset_bExitReverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061C8 RID: 25032
		// (get) Token: 0x060187D9 RID: 100313 RVA: 0x00241634 File Offset: 0x0023F834
		// (set) Token: 0x060187DA RID: 100314 RVA: 0x00241677 File Offset: 0x0023F877
		public FCollisionProfileName ExitCollision
		{
			get
			{
				base.FastCheckIsValid();
				FCollisionProfileName result;
				if ((result = this._ExitCollision) == null)
				{
					result = (this._ExitCollision = new FCollisionProfileName(base.NativePtr + (IntPtr)FKuroLevelSwitchCollisionData.__PropertyOffset_ExitCollision, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionProfileName.StaticStruct(), base.NativePtr + (IntPtr)FKuroLevelSwitchCollisionData.__PropertyOffset_ExitCollision, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060187DB RID: 100315 RVA: 0x00241698 File Offset: 0x0023F898
		public FKuroLevelSwitchCollisionData()
		{
		}

		// Token: 0x060187DC RID: 100316 RVA: 0x002416A0 File Offset: 0x0023F8A0
		public FKuroLevelSwitchCollisionData(AActor Actor, bool bIncludeChildren, FCollisionProfileName EnterCollision, bool bExitReverse, FCollisionProfileName ExitCollision)
		{
			this.Actor = Actor;
			this.bIncludeChildren = bIncludeChildren;
			this.EnterCollision = EnterCollision;
			this.bExitReverse = bExitReverse;
			this.ExitCollision = ExitCollision;
		}

		// Token: 0x060187DD RID: 100317 RVA: 0x002416CD File Offset: 0x0023F8CD
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLevelSwitchCollisionData.StaticStruct();
		}

		// Token: 0x060187DE RID: 100318 RVA: 0x002416D9 File Offset: 0x0023F8D9
		[NullableContext(2)]
		public FKuroLevelSwitchCollisionData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060187DF RID: 100319 RVA: 0x002416E3 File Offset: 0x0023F8E3
		public FKuroLevelSwitchCollisionData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060187E0 RID: 100320 RVA: 0x002416EE File Offset: 0x0023F8EE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLevelSwitchCollisionData(Pointer, false, true);
		}

		// Token: 0x060187E1 RID: 100321 RVA: 0x002416F8 File Offset: 0x0023F8F8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLevelSwitchCollisionData(Pointer, MemoryOwner);
		}

		// Token: 0x0400D3A5 RID: 54181
		public const string __ObjectPath = "/Script/KuroLevelStateMachine.KuroLevelSwitchCollisionData";

		// Token: 0x0400D3A6 RID: 54182
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D3A7 RID: 54183
		internal static int __PropertyOffset_Actor;

		// Token: 0x0400D3A8 RID: 54184
		internal static int __PropertyOffset_bIncludeChildren;

		// Token: 0x0400D3A9 RID: 54185
		internal static int __PropertyOffset_EnterCollision;

		// Token: 0x0400D3AA RID: 54186
		[Nullable(2)]
		private FCollisionProfileName _EnterCollision;

		// Token: 0x0400D3AB RID: 54187
		internal static int __PropertyOffset_bExitReverse;

		// Token: 0x0400D3AC RID: 54188
		internal static int __PropertyOffset_ExitCollision;

		// Token: 0x0400D3AD RID: 54189
		[Nullable(2)]
		private FCollisionProfileName _ExitCollision;
	}
}
