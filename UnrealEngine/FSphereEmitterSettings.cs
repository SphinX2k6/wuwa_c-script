using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200170F RID: 5903
	[UnrealObjectPath("/Script/KuroBulletCore.SphereEmitterSettings")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSphereEmitterSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060154D5 RID: 87253 RVA: 0x001F4F45 File Offset: 0x001F3145
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSphereEmitterSettings._ScriptStructPtr != 0) ? FSphereEmitterSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.SphereEmitterSettings", ref FSphereEmitterSettings._ScriptStructPtr);
		}

		// Token: 0x17005434 RID: 21556
		// (get) Token: 0x060154D6 RID: 87254 RVA: 0x001F4F69 File Offset: 0x001F3169
		// (set) Token: 0x060154D7 RID: 87255 RVA: 0x001F4F79 File Offset: 0x001F3179
		public unsafe float SphereRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSphereEmitterSettings.__PropertyOffset_SphereRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSphereEmitterSettings.__PropertyOffset_SphereRadius) = value;
			}
		}

		// Token: 0x17005435 RID: 21557
		// (get) Token: 0x060154D8 RID: 87256 RVA: 0x001F4F8A File Offset: 0x001F318A
		// (set) Token: 0x060154D9 RID: 87257 RVA: 0x001F4F9A File Offset: 0x001F319A
		public unsafe int NumLatitudes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSphereEmitterSettings.__PropertyOffset_NumLatitudes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSphereEmitterSettings.__PropertyOffset_NumLatitudes) = value;
			}
		}

		// Token: 0x17005436 RID: 21558
		// (get) Token: 0x060154DA RID: 87258 RVA: 0x001F4FAB File Offset: 0x001F31AB
		// (set) Token: 0x060154DB RID: 87259 RVA: 0x001F4FBF File Offset: 0x001F31BF
		public unsafe FVector2D BaseRotationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSphereEmitterSettings.__PropertyOffset_BaseRotationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSphereEmitterSettings.__PropertyOffset_BaseRotationOffset) = value;
			}
		}

		// Token: 0x17005437 RID: 21559
		// (get) Token: 0x060154DC RID: 87260 RVA: 0x001F4FD4 File Offset: 0x001F31D4
		// (set) Token: 0x060154DD RID: 87261 RVA: 0x001F4FE8 File Offset: 0x001F31E8
		public unsafe FVector2D FillRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSphereEmitterSettings.__PropertyOffset_FillRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSphereEmitterSettings.__PropertyOffset_FillRange) = value;
			}
		}

		// Token: 0x060154DE RID: 87262 RVA: 0x001F4FFD File Offset: 0x001F31FD
		public FSphereEmitterSettings()
		{
		}

		// Token: 0x060154DF RID: 87263 RVA: 0x001F5005 File Offset: 0x001F3205
		public FSphereEmitterSettings(float SphereRadius, int NumLatitudes, FVector2D BaseRotationOffset, FVector2D FillRange)
		{
			this.SphereRadius = SphereRadius;
			this.NumLatitudes = NumLatitudes;
			this.BaseRotationOffset = BaseRotationOffset;
			this.FillRange = FillRange;
		}

		// Token: 0x060154E0 RID: 87264 RVA: 0x001F502A File Offset: 0x001F322A
		protected override IntPtr GetUStructPtr()
		{
			return FSphereEmitterSettings.StaticStruct();
		}

		// Token: 0x060154E1 RID: 87265 RVA: 0x001F5036 File Offset: 0x001F3236
		[NullableContext(2)]
		public FSphereEmitterSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060154E2 RID: 87266 RVA: 0x001F5040 File Offset: 0x001F3240
		public FSphereEmitterSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060154E3 RID: 87267 RVA: 0x001F504B File Offset: 0x001F324B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSphereEmitterSettings(Pointer, false, true);
		}

		// Token: 0x060154E4 RID: 87268 RVA: 0x001F5055 File Offset: 0x001F3255
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSphereEmitterSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400B9C7 RID: 47559
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBulletCore.SphereEmitterSettings";

		// Token: 0x0400B9C8 RID: 47560
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B9C9 RID: 47561
		internal static int __PropertyOffset_SphereRadius;

		// Token: 0x0400B9CA RID: 47562
		internal static int __PropertyOffset_NumLatitudes;

		// Token: 0x0400B9CB RID: 47563
		internal static int __PropertyOffset_BaseRotationOffset;

		// Token: 0x0400B9CC RID: 47564
		internal static int __PropertyOffset_FillRange;
	}
}
