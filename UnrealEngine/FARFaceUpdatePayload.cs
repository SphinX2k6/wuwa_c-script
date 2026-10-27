using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003A3 RID: 931
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARFaceUpdatePayload")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FARFaceUpdatePayload : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060033A2 RID: 13218 RVA: 0x0004EFF1 File Offset: 0x0004D1F1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FARFaceUpdatePayload._ScriptStructPtr != 0) ? FARFaceUpdatePayload._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AugmentedReality.ARFaceUpdatePayload", ref FARFaceUpdatePayload._ScriptStructPtr);
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x060033A3 RID: 13219 RVA: 0x0004F018 File Offset: 0x0004D218
		// (set) Token: 0x060033A4 RID: 13220 RVA: 0x0004F05B File Offset: 0x0004D25B
		public FARSessionPayload SessionPayload
		{
			get
			{
				base.FastCheckIsValid();
				FARSessionPayload result;
				if ((result = this._SessionPayload) == null)
				{
					result = (this._SessionPayload = new FARSessionPayload(base.NativePtr + (IntPtr)FARFaceUpdatePayload.__PropertyOffset_SessionPayload, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FARSessionPayload.StaticStruct(), base.NativePtr + (IntPtr)FARFaceUpdatePayload.__PropertyOffset_SessionPayload, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x060033A5 RID: 13221 RVA: 0x0004F07C File Offset: 0x0004D27C
		// (set) Token: 0x060033A6 RID: 13222 RVA: 0x0004F090 File Offset: 0x0004D290
		public unsafe FVector LeftEyePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARFaceUpdatePayload.__PropertyOffset_LeftEyePosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARFaceUpdatePayload.__PropertyOffset_LeftEyePosition) = value;
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x060033A7 RID: 13223 RVA: 0x0004F0A5 File Offset: 0x0004D2A5
		// (set) Token: 0x060033A8 RID: 13224 RVA: 0x0004F0B9 File Offset: 0x0004D2B9
		public unsafe FVector RightEyePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARFaceUpdatePayload.__PropertyOffset_RightEyePosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARFaceUpdatePayload.__PropertyOffset_RightEyePosition) = value;
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x060033A9 RID: 13225 RVA: 0x0004F0CE File Offset: 0x0004D2CE
		// (set) Token: 0x060033AA RID: 13226 RVA: 0x0004F0E2 File Offset: 0x0004D2E2
		public unsafe FVector LookAtTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARFaceUpdatePayload.__PropertyOffset_LookAtTarget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARFaceUpdatePayload.__PropertyOffset_LookAtTarget) = value;
			}
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x0004F0F7 File Offset: 0x0004D2F7
		public FARFaceUpdatePayload()
		{
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x0004F0FF File Offset: 0x0004D2FF
		public FARFaceUpdatePayload(FARSessionPayload SessionPayload, FVector LeftEyePosition, FVector RightEyePosition, FVector LookAtTarget)
		{
			this.SessionPayload = SessionPayload;
			this.LeftEyePosition = LeftEyePosition;
			this.RightEyePosition = RightEyePosition;
			this.LookAtTarget = LookAtTarget;
		}

		// Token: 0x060033AD RID: 13229 RVA: 0x0004F124 File Offset: 0x0004D324
		protected override IntPtr GetUStructPtr()
		{
			return FARFaceUpdatePayload.StaticStruct();
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x0004F130 File Offset: 0x0004D330
		[NullableContext(2)]
		public FARFaceUpdatePayload(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x0004F13A File Offset: 0x0004D33A
		public FARFaceUpdatePayload(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x0004F145 File Offset: 0x0004D345
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FARFaceUpdatePayload(Pointer, false, true);
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x0004F14F File Offset: 0x0004D34F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FARFaceUpdatePayload(Pointer, MemoryOwner);
		}

		// Token: 0x0400166C RID: 5740
		public const string __ObjectPath = "/Script/AugmentedReality.ARFaceUpdatePayload";

		// Token: 0x0400166D RID: 5741
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400166E RID: 5742
		internal static int __PropertyOffset_SessionPayload;

		// Token: 0x0400166F RID: 5743
		[Nullable(2)]
		private FARSessionPayload _SessionPayload;

		// Token: 0x04001670 RID: 5744
		internal static int __PropertyOffset_LeftEyePosition;

		// Token: 0x04001671 RID: 5745
		internal static int __PropertyOffset_RightEyePosition;

		// Token: 0x04001672 RID: 5746
		internal static int __PropertyOffset_LookAtTarget;
	}
}
