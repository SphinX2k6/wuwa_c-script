using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DEE RID: 7662
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_KuroFX")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKSC_KuroFX : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D489 RID: 119945 RVA: 0x002B3D6A File Offset: 0x002B1F6A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_KuroFX._ScriptStructPtr != 0) ? FKSC_KuroFX._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_KuroFX", ref FKSC_KuroFX._ScriptStructPtr);
		}

		// Token: 0x17007643 RID: 30275
		// (get) Token: 0x0601D48A RID: 119946 RVA: 0x002B3D8E File Offset: 0x002B1F8E
		// (set) Token: 0x0601D48B RID: 119947 RVA: 0x002B3DA2 File Offset: 0x002B1FA2
		[Nullable(2)]
		public unsafe UEffectModelBase FX
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_KuroFX.__PropertyOffset_FX);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_KuroFX.__PropertyOffset_FX, value);
			}
		}

		// Token: 0x17007644 RID: 30276
		// (get) Token: 0x0601D48C RID: 119948 RVA: 0x002B3DB7 File Offset: 0x002B1FB7
		// (set) Token: 0x0601D48D RID: 119949 RVA: 0x002B3DCB File Offset: 0x002B1FCB
		public unsafe FTransform FX_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_KuroFX.__PropertyOffset_FX_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_KuroFX.__PropertyOffset_FX_Offset) = value;
			}
		}

		// Token: 0x17007645 RID: 30277
		// (get) Token: 0x0601D48E RID: 119950 RVA: 0x002B3DE0 File Offset: 0x002B1FE0
		// (set) Token: 0x0601D48F RID: 119951 RVA: 0x002B3DF4 File Offset: 0x002B1FF4
		public unsafe FName Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_KuroFX.__PropertyOffset_Socket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_KuroFX.__PropertyOffset_Socket) = value;
			}
		}

		// Token: 0x17007646 RID: 30278
		// (get) Token: 0x0601D490 RID: 119952 RVA: 0x002B3E09 File Offset: 0x002B2009
		// (set) Token: 0x0601D491 RID: 119953 RVA: 0x002B3E19 File Offset: 0x002B2019
		public unsafe bool FX_AttackLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_KuroFX.__PropertyOffset_FX_AttackLocation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_KuroFX.__PropertyOffset_FX_AttackLocation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007647 RID: 30279
		// (get) Token: 0x0601D492 RID: 119954 RVA: 0x002B3E2A File Offset: 0x002B202A
		// (set) Token: 0x0601D493 RID: 119955 RVA: 0x002B3E3A File Offset: 0x002B203A
		public unsafe bool FX_AttackRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_KuroFX.__PropertyOffset_FX_AttackRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_KuroFX.__PropertyOffset_FX_AttackRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007648 RID: 30280
		// (get) Token: 0x0601D494 RID: 119956 RVA: 0x002B3E4B File Offset: 0x002B204B
		// (set) Token: 0x0601D495 RID: 119957 RVA: 0x002B3E5B File Offset: 0x002B205B
		public unsafe bool FX_AttackScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_KuroFX.__PropertyOffset_FX_AttackScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_KuroFX.__PropertyOffset_FX_AttackScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601D496 RID: 119958 RVA: 0x002B3E6C File Offset: 0x002B206C
		public FKSC_KuroFX()
		{
		}

		// Token: 0x0601D497 RID: 119959 RVA: 0x002B3E74 File Offset: 0x002B2074
		[NullableContext(1)]
		public FKSC_KuroFX(UEffectModelBase FX, FTransform FX_Offset, FName Socket, bool FX_AttackLocation, bool FX_AttackRotation, bool FX_AttackScale)
		{
			this.FX = FX;
			this.FX_Offset = FX_Offset;
			this.Socket = Socket;
			this.FX_AttackLocation = FX_AttackLocation;
			this.FX_AttackRotation = FX_AttackRotation;
			this.FX_AttackScale = FX_AttackScale;
		}

		// Token: 0x0601D498 RID: 119960 RVA: 0x002B3EA9 File Offset: 0x002B20A9
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_KuroFX.StaticStruct();
		}

		// Token: 0x0601D499 RID: 119961 RVA: 0x002B3EB5 File Offset: 0x002B20B5
		[NullableContext(2)]
		public FKSC_KuroFX(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D49A RID: 119962 RVA: 0x002B3EBF File Offset: 0x002B20BF
		public FKSC_KuroFX(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D49B RID: 119963 RVA: 0x002B3ECA File Offset: 0x002B20CA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_KuroFX(Pointer, false, true);
		}

		// Token: 0x0601D49C RID: 119964 RVA: 0x002B3ED4 File Offset: 0x002B20D4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_KuroFX(Pointer, MemoryOwner);
		}

		// Token: 0x0400FE3F RID: 65087
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_KuroFX";

		// Token: 0x0400FE40 RID: 65088
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FE41 RID: 65089
		internal static int __PropertyOffset_FX;

		// Token: 0x0400FE42 RID: 65090
		internal static int __PropertyOffset_FX_Offset;

		// Token: 0x0400FE43 RID: 65091
		internal static int __PropertyOffset_Socket;

		// Token: 0x0400FE44 RID: 65092
		internal static int __PropertyOffset_FX_AttackLocation;

		// Token: 0x0400FE45 RID: 65093
		internal static int __PropertyOffset_FX_AttackRotation;

		// Token: 0x0400FE46 RID: 65094
		internal static int __PropertyOffset_FX_AttackScale;
	}
}
