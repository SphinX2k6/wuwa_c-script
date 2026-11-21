using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200015F RID: 351
	[UnrealObjectPath("/Script/Engine.ActiveCameraShakeInfo")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FActiveCameraShakeInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001397 RID: 5015 RVA: 0x0001EDF5 File Offset: 0x0001CFF5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActiveCameraShakeInfo._ScriptStructPtr != 0) ? FActiveCameraShakeInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActiveCameraShakeInfo", ref FActiveCameraShakeInfo._ScriptStructPtr);
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x0001EE19 File Offset: 0x0001D019
		// (set) Token: 0x06001399 RID: 5017 RVA: 0x0001EE2D File Offset: 0x0001D02D
		[Nullable(2)]
		public unsafe UCameraShakeBase ShakeInstance
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCameraShakeBase>(base.NativePtr / (IntPtr)sizeof(void*) + FActiveCameraShakeInfo.__PropertyOffset_ShakeInstance);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FActiveCameraShakeInfo.__PropertyOffset_ShakeInstance, value);
			}
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x0001EE42 File Offset: 0x0001D042
		public FActiveCameraShakeInfo()
		{
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x0001EE4A File Offset: 0x0001D04A
		protected override IntPtr GetUStructPtr()
		{
			return FActiveCameraShakeInfo.StaticStruct();
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x0001EE56 File Offset: 0x0001D056
		[NullableContext(2)]
		public FActiveCameraShakeInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x0001EE60 File Offset: 0x0001D060
		public FActiveCameraShakeInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x0001EE6B File Offset: 0x0001D06B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActiveCameraShakeInfo(Pointer, false, true);
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0001EE75 File Offset: 0x0001D075
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActiveCameraShakeInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04000658 RID: 1624
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActiveCameraShakeInfo";

		// Token: 0x04000659 RID: 1625
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400065A RID: 1626
		internal static int __PropertyOffset_ShakeInstance;
	}
}
