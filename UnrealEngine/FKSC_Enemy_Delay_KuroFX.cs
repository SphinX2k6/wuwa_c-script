using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DDA RID: 7642
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Enemy_Delay_KuroFX")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FKSC_Enemy_Delay_KuroFX : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D320 RID: 119584 RVA: 0x002B202A File Offset: 0x002B022A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_Enemy_Delay_KuroFX._ScriptStructPtr != 0) ? FKSC_Enemy_Delay_KuroFX._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_Enemy_Delay_KuroFX", ref FKSC_Enemy_Delay_KuroFX._ScriptStructPtr);
		}

		// Token: 0x170075EC RID: 30188
		// (get) Token: 0x0601D321 RID: 119585 RVA: 0x002B204E File Offset: 0x002B024E
		// (set) Token: 0x0601D322 RID: 119586 RVA: 0x002B205E File Offset: 0x002B025E
		public unsafe float Delay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Enemy_Delay_KuroFX.__PropertyOffset_Delay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Enemy_Delay_KuroFX.__PropertyOffset_Delay) = value;
			}
		}

		// Token: 0x170075ED RID: 30189
		// (get) Token: 0x0601D323 RID: 119587 RVA: 0x002B2070 File Offset: 0x002B0270
		// (set) Token: 0x0601D324 RID: 119588 RVA: 0x002B20B3 File Offset: 0x002B02B3
		public FKSC_KuroFX KuroFX
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_KuroFX result;
				if ((result = this._KuroFX) == null)
				{
					result = (this._KuroFX = new FKSC_KuroFX(base.NativePtr + (IntPtr)FKSC_Enemy_Delay_KuroFX.__PropertyOffset_KuroFX, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_KuroFX.StaticStruct(), base.NativePtr + (IntPtr)FKSC_Enemy_Delay_KuroFX.__PropertyOffset_KuroFX, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601D325 RID: 119589 RVA: 0x002B20D4 File Offset: 0x002B02D4
		public FKSC_Enemy_Delay_KuroFX()
		{
		}

		// Token: 0x0601D326 RID: 119590 RVA: 0x002B20DC File Offset: 0x002B02DC
		public FKSC_Enemy_Delay_KuroFX(float Delay, FKSC_KuroFX KuroFX)
		{
			this.Delay = Delay;
			this.KuroFX = KuroFX;
		}

		// Token: 0x0601D327 RID: 119591 RVA: 0x002B20F2 File Offset: 0x002B02F2
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_Enemy_Delay_KuroFX.StaticStruct();
		}

		// Token: 0x0601D328 RID: 119592 RVA: 0x002B20FE File Offset: 0x002B02FE
		[NullableContext(2)]
		public FKSC_Enemy_Delay_KuroFX(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D329 RID: 119593 RVA: 0x002B2108 File Offset: 0x002B0308
		public FKSC_Enemy_Delay_KuroFX(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D32A RID: 119594 RVA: 0x002B2113 File Offset: 0x002B0313
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_Enemy_Delay_KuroFX(Pointer, false, true);
		}

		// Token: 0x0601D32B RID: 119595 RVA: 0x002B211D File Offset: 0x002B031D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_Enemy_Delay_KuroFX(Pointer, MemoryOwner);
		}

		// Token: 0x0400FD96 RID: 64918
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Enemy_Delay_KuroFX";

		// Token: 0x0400FD97 RID: 64919
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FD98 RID: 64920
		internal static int __PropertyOffset_Delay;

		// Token: 0x0400FD99 RID: 64921
		internal static int __PropertyOffset_KuroFX;

		// Token: 0x0400FD9A RID: 64922
		[Nullable(2)]
		private FKSC_KuroFX _KuroFX;
	}
}
