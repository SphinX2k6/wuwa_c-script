using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002C9 RID: 713
	[UnrealObjectPath("/Script/AnimationCore.TransformNoScale")]
	[UnrealStructLayout(32, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FTransformNoScale : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002785 RID: 10117 RVA: 0x0003B419 File Offset: 0x00039619
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransformNoScale._ScriptStructPtr != 0) ? FTransformNoScale._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimationCore.TransformNoScale", ref FTransformNoScale._ScriptStructPtr);
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06002786 RID: 10118 RVA: 0x0003B43D File Offset: 0x0003963D
		// (set) Token: 0x06002787 RID: 10119 RVA: 0x0003B451 File Offset: 0x00039651
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransformNoScale.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransformNoScale.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06002788 RID: 10120 RVA: 0x0003B466 File Offset: 0x00039666
		// (set) Token: 0x06002789 RID: 10121 RVA: 0x0003B47A File Offset: 0x0003967A
		public unsafe FQuat Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransformNoScale.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransformNoScale.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x0003B48F File Offset: 0x0003968F
		public FTransformNoScale()
		{
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x0003B497 File Offset: 0x00039697
		public FTransformNoScale(FVector Location, FQuat Rotation)
		{
			this.Location = Location;
			this.Rotation = Rotation;
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x0003B4AD File Offset: 0x000396AD
		protected override IntPtr GetUStructPtr()
		{
			return FTransformNoScale.StaticStruct();
		}

		// Token: 0x0600278D RID: 10125 RVA: 0x0003B4B9 File Offset: 0x000396B9
		[NullableContext(2)]
		public FTransformNoScale(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600278E RID: 10126 RVA: 0x0003B4C3 File Offset: 0x000396C3
		public FTransformNoScale(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x0003B4CE File Offset: 0x000396CE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTransformNoScale(Pointer, false, true);
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x0003B4D8 File Offset: 0x000396D8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTransformNoScale(Pointer, MemoryOwner);
		}

		// Token: 0x04000F96 RID: 3990
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimationCore.TransformNoScale";

		// Token: 0x04000F97 RID: 3991
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000F98 RID: 3992
		internal static int __PropertyOffset_Location;

		// Token: 0x04000F99 RID: 3993
		internal static int __PropertyOffset_Rotation;
	}
}
