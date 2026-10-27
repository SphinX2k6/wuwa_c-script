using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000398 RID: 920
	[UnrealObjectPath("/Script/AugmentedReality.ARCameraIntrinsics")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FARCameraIntrinsics : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060032DF RID: 13023 RVA: 0x0004E205 File Offset: 0x0004C405
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FARCameraIntrinsics._ScriptStructPtr != 0) ? FARCameraIntrinsics._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AugmentedReality.ARCameraIntrinsics", ref FARCameraIntrinsics._ScriptStructPtr);
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x060032E0 RID: 13024 RVA: 0x0004E229 File Offset: 0x0004C429
		// (set) Token: 0x060032E1 RID: 13025 RVA: 0x0004E23D File Offset: 0x0004C43D
		public unsafe FIntPoint ImageResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARCameraIntrinsics.__PropertyOffset_ImageResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARCameraIntrinsics.__PropertyOffset_ImageResolution) = value;
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x060032E2 RID: 13026 RVA: 0x0004E252 File Offset: 0x0004C452
		// (set) Token: 0x060032E3 RID: 13027 RVA: 0x0004E266 File Offset: 0x0004C466
		public unsafe FVector2D FocalLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARCameraIntrinsics.__PropertyOffset_FocalLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARCameraIntrinsics.__PropertyOffset_FocalLength) = value;
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x060032E4 RID: 13028 RVA: 0x0004E27B File Offset: 0x0004C47B
		// (set) Token: 0x060032E5 RID: 13029 RVA: 0x0004E28F File Offset: 0x0004C48F
		public unsafe FVector2D PrincipalPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARCameraIntrinsics.__PropertyOffset_PrincipalPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARCameraIntrinsics.__PropertyOffset_PrincipalPoint) = value;
			}
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x0004E2A4 File Offset: 0x0004C4A4
		public FARCameraIntrinsics()
		{
		}

		// Token: 0x060032E7 RID: 13031 RVA: 0x0004E2AC File Offset: 0x0004C4AC
		public FARCameraIntrinsics(FIntPoint ImageResolution, FVector2D FocalLength, FVector2D PrincipalPoint)
		{
			this.ImageResolution = ImageResolution;
			this.FocalLength = FocalLength;
			this.PrincipalPoint = PrincipalPoint;
		}

		// Token: 0x060032E8 RID: 13032 RVA: 0x0004E2C9 File Offset: 0x0004C4C9
		protected override IntPtr GetUStructPtr()
		{
			return FARCameraIntrinsics.StaticStruct();
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x0004E2D5 File Offset: 0x0004C4D5
		[NullableContext(2)]
		public FARCameraIntrinsics(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060032EA RID: 13034 RVA: 0x0004E2DF File Offset: 0x0004C4DF
		public FARCameraIntrinsics(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060032EB RID: 13035 RVA: 0x0004E2EA File Offset: 0x0004C4EA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FARCameraIntrinsics(Pointer, false, true);
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x0004E2F4 File Offset: 0x0004C4F4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FARCameraIntrinsics(Pointer, MemoryOwner);
		}

		// Token: 0x04001627 RID: 5671
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.ARCameraIntrinsics";

		// Token: 0x04001628 RID: 5672
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001629 RID: 5673
		internal static int __PropertyOffset_ImageResolution;

		// Token: 0x0400162A RID: 5674
		internal static int __PropertyOffset_FocalLength;

		// Token: 0x0400162B RID: 5675
		internal static int __PropertyOffset_PrincipalPoint;
	}
}
