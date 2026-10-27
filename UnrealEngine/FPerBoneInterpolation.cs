using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FD5 RID: 4053
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PerBoneInterpolation")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FPerBoneInterpolation : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600DAF2 RID: 56050 RVA: 0x00142BFC File Offset: 0x00140DFC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPerBoneInterpolation._ScriptStructPtr != 0) ? FPerBoneInterpolation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PerBoneInterpolation", ref FPerBoneInterpolation._ScriptStructPtr);
		}

		// Token: 0x170033A5 RID: 13221
		// (get) Token: 0x0600DAF3 RID: 56051 RVA: 0x00142C20 File Offset: 0x00140E20
		// (set) Token: 0x0600DAF4 RID: 56052 RVA: 0x00142C63 File Offset: 0x00140E63
		public FBoneReference BoneReference
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._BoneReference) == null)
				{
					result = (this._BoneReference = new FBoneReference(base.NativePtr + (IntPtr)FPerBoneInterpolation.__PropertyOffset_BoneReference, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FPerBoneInterpolation.__PropertyOffset_BoneReference, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170033A6 RID: 13222
		// (get) Token: 0x0600DAF5 RID: 56053 RVA: 0x00142C84 File Offset: 0x00140E84
		// (set) Token: 0x0600DAF6 RID: 56054 RVA: 0x00142C94 File Offset: 0x00140E94
		public unsafe float InterpolationSpeedPerSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerBoneInterpolation.__PropertyOffset_InterpolationSpeedPerSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerBoneInterpolation.__PropertyOffset_InterpolationSpeedPerSec) = value;
			}
		}

		// Token: 0x0600DAF7 RID: 56055 RVA: 0x00142CA5 File Offset: 0x00140EA5
		public FPerBoneInterpolation()
		{
		}

		// Token: 0x0600DAF8 RID: 56056 RVA: 0x00142CAD File Offset: 0x00140EAD
		public FPerBoneInterpolation(FBoneReference BoneReference, float InterpolationSpeedPerSec)
		{
			this.BoneReference = BoneReference;
			this.InterpolationSpeedPerSec = InterpolationSpeedPerSec;
		}

		// Token: 0x0600DAF9 RID: 56057 RVA: 0x00142CC3 File Offset: 0x00140EC3
		protected override IntPtr GetUStructPtr()
		{
			return FPerBoneInterpolation.StaticStruct();
		}

		// Token: 0x0600DAFA RID: 56058 RVA: 0x00142CCF File Offset: 0x00140ECF
		[NullableContext(2)]
		public FPerBoneInterpolation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DAFB RID: 56059 RVA: 0x00142CD9 File Offset: 0x00140ED9
		public FPerBoneInterpolation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DAFC RID: 56060 RVA: 0x00142CE4 File Offset: 0x00140EE4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPerBoneInterpolation(Pointer, false, true);
		}

		// Token: 0x0600DAFD RID: 56061 RVA: 0x00142CEE File Offset: 0x00140EEE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPerBoneInterpolation(Pointer, MemoryOwner);
		}

		// Token: 0x04007688 RID: 30344
		public const string __ObjectPath = "/Script/Engine.PerBoneInterpolation";

		// Token: 0x04007689 RID: 30345
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400768A RID: 30346
		internal static int __PropertyOffset_BoneReference;

		// Token: 0x0400768B RID: 30347
		[Nullable(2)]
		private FBoneReference _BoneReference;

		// Token: 0x0400768C RID: 30348
		internal static int __PropertyOffset_InterpolationSpeedPerSec;
	}
}
