using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FDC RID: 4060
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PhysicalAnimationProfile")]
	[UnrealStructLayout(52, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 52)]
	public class FPhysicalAnimationProfile : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600DB53 RID: 56147 RVA: 0x00143270 File Offset: 0x00141470
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPhysicalAnimationProfile._ScriptStructPtr != 0) ? FPhysicalAnimationProfile._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PhysicalAnimationProfile", ref FPhysicalAnimationProfile._ScriptStructPtr);
		}

		// Token: 0x170033B5 RID: 13237
		// (get) Token: 0x0600DB54 RID: 56148 RVA: 0x00143294 File Offset: 0x00141494
		// (set) Token: 0x0600DB55 RID: 56149 RVA: 0x001432A8 File Offset: 0x001414A8
		public unsafe FName ProfileName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhysicalAnimationProfile.__PropertyOffset_ProfileName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhysicalAnimationProfile.__PropertyOffset_ProfileName) = value;
			}
		}

		// Token: 0x170033B6 RID: 13238
		// (get) Token: 0x0600DB56 RID: 56150 RVA: 0x001432C0 File Offset: 0x001414C0
		// (set) Token: 0x0600DB57 RID: 56151 RVA: 0x00143303 File Offset: 0x00141503
		public FPhysicalAnimationData PhysicalAnimationData
		{
			get
			{
				base.FastCheckIsValid();
				FPhysicalAnimationData result;
				if ((result = this._PhysicalAnimationData) == null)
				{
					result = (this._PhysicalAnimationData = new FPhysicalAnimationData(base.NativePtr + (IntPtr)FPhysicalAnimationProfile.__PropertyOffset_PhysicalAnimationData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPhysicalAnimationData.StaticStruct(), base.NativePtr + (IntPtr)FPhysicalAnimationProfile.__PropertyOffset_PhysicalAnimationData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600DB58 RID: 56152 RVA: 0x00143324 File Offset: 0x00141524
		public FPhysicalAnimationProfile()
		{
		}

		// Token: 0x0600DB59 RID: 56153 RVA: 0x0014332C File Offset: 0x0014152C
		public FPhysicalAnimationProfile(FName ProfileName, FPhysicalAnimationData PhysicalAnimationData)
		{
			this.ProfileName = ProfileName;
			this.PhysicalAnimationData = PhysicalAnimationData;
		}

		// Token: 0x0600DB5A RID: 56154 RVA: 0x00143342 File Offset: 0x00141542
		protected override IntPtr GetUStructPtr()
		{
			return FPhysicalAnimationProfile.StaticStruct();
		}

		// Token: 0x0600DB5B RID: 56155 RVA: 0x0014334E File Offset: 0x0014154E
		[NullableContext(2)]
		public FPhysicalAnimationProfile(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DB5C RID: 56156 RVA: 0x00143358 File Offset: 0x00141558
		public FPhysicalAnimationProfile(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DB5D RID: 56157 RVA: 0x00143363 File Offset: 0x00141563
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPhysicalAnimationProfile(Pointer, false, true);
		}

		// Token: 0x0600DB5E RID: 56158 RVA: 0x0014336D File Offset: 0x0014156D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPhysicalAnimationProfile(Pointer, MemoryOwner);
		}

		// Token: 0x040076A9 RID: 30377
		public const string __ObjectPath = "/Script/Engine.PhysicalAnimationProfile";

		// Token: 0x040076AA RID: 30378
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040076AB RID: 30379
		internal static int __PropertyOffset_ProfileName;

		// Token: 0x040076AC RID: 30380
		internal static int __PropertyOffset_PhysicalAnimationData;

		// Token: 0x040076AD RID: 30381
		[Nullable(2)]
		private FPhysicalAnimationData _PhysicalAnimationData;
	}
}
