using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200179A RID: 6042
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroClothLocalCollider")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FKuroClothLocalCollider : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015C67 RID: 89191 RVA: 0x001FFD30 File Offset: 0x001FDF30
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroClothLocalCollider._ScriptStructPtr != 0) ? FKuroClothLocalCollider._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroClothLocalCollider", ref FKuroClothLocalCollider._ScriptStructPtr);
		}

		// Token: 0x1700563C RID: 22076
		// (get) Token: 0x06015C68 RID: 89192 RVA: 0x001FFD54 File Offset: 0x001FDF54
		// (set) Token: 0x06015C69 RID: 89193 RVA: 0x001FFD68 File Offset: 0x001FDF68
		public unsafe string Id
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroClothLocalCollider.__PropertyOffset_Id)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroClothLocalCollider.__PropertyOffset_Id)), value);
			}
		}

		// Token: 0x1700563D RID: 22077
		// (get) Token: 0x06015C6A RID: 89194 RVA: 0x001FFD7D File Offset: 0x001FDF7D
		// (set) Token: 0x06015C6B RID: 89195 RVA: 0x001FFD91 File Offset: 0x001FDF91
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroClothLocalCollider.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroClothLocalCollider.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x1700563E RID: 22078
		// (get) Token: 0x06015C6C RID: 89196 RVA: 0x001FFDA6 File Offset: 0x001FDFA6
		// (set) Token: 0x06015C6D RID: 89197 RVA: 0x001FFDB6 File Offset: 0x001FDFB6
		public unsafe EKuroClothLocalColliderType Shape
		{
			get
			{
				return (EKuroClothLocalColliderType)(*(base.NativePtr + (IntPtr)FKuroClothLocalCollider.__PropertyOffset_Shape));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothLocalCollider.__PropertyOffset_Shape) = (byte)value;
			}
		}

		// Token: 0x1700563F RID: 22079
		// (get) Token: 0x06015C6E RID: 89198 RVA: 0x001FFDC7 File Offset: 0x001FDFC7
		// (set) Token: 0x06015C6F RID: 89199 RVA: 0x001FFDDB File Offset: 0x001FDFDB
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothLocalCollider.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothLocalCollider.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x17005640 RID: 22080
		// (get) Token: 0x06015C70 RID: 89200 RVA: 0x001FFDF0 File Offset: 0x001FDFF0
		// (set) Token: 0x06015C71 RID: 89201 RVA: 0x001FFE04 File Offset: 0x001FE004
		public unsafe FVector Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothLocalCollider.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothLocalCollider.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17005641 RID: 22081
		// (get) Token: 0x06015C72 RID: 89202 RVA: 0x001FFE19 File Offset: 0x001FE019
		// (set) Token: 0x06015C73 RID: 89203 RVA: 0x001FFE2D File Offset: 0x001FE02D
		public unsafe FVector HalfSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothLocalCollider.__PropertyOffset_HalfSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothLocalCollider.__PropertyOffset_HalfSize) = value;
			}
		}

		// Token: 0x17005642 RID: 22082
		// (get) Token: 0x06015C74 RID: 89204 RVA: 0x001FFE42 File Offset: 0x001FE042
		// (set) Token: 0x06015C75 RID: 89205 RVA: 0x001FFE52 File Offset: 0x001FE052
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothLocalCollider.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothLocalCollider.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17005643 RID: 22083
		// (get) Token: 0x06015C76 RID: 89206 RVA: 0x001FFE63 File Offset: 0x001FE063
		// (set) Token: 0x06015C77 RID: 89207 RVA: 0x001FFE73 File Offset: 0x001FE073
		public unsafe float Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothLocalCollider.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothLocalCollider.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x17005644 RID: 22084
		// (get) Token: 0x06015C78 RID: 89208 RVA: 0x001FFE84 File Offset: 0x001FE084
		// (set) Token: 0x06015C79 RID: 89209 RVA: 0x001FFE94 File Offset: 0x001FE094
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothLocalCollider.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothLocalCollider.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06015C7A RID: 89210 RVA: 0x001FFEA5 File Offset: 0x001FE0A5
		public FKuroClothLocalCollider()
		{
		}

		// Token: 0x06015C7B RID: 89211 RVA: 0x001FFEB0 File Offset: 0x001FE0B0
		public FKuroClothLocalCollider(string Id, string Name, EKuroClothLocalColliderType Shape, FVector Center, FVector Rotation, FVector HalfSize, float Radius, float Height, bool bEnabled)
		{
			this.Id = Id;
			this.Name = Name;
			this.Shape = Shape;
			this.Center = Center;
			this.Rotation = Rotation;
			this.HalfSize = HalfSize;
			this.Radius = Radius;
			this.Height = Height;
			this.bEnabled = bEnabled;
		}

		// Token: 0x06015C7C RID: 89212 RVA: 0x001FFF08 File Offset: 0x001FE108
		protected override IntPtr GetUStructPtr()
		{
			return FKuroClothLocalCollider.StaticStruct();
		}

		// Token: 0x06015C7D RID: 89213 RVA: 0x001FFF14 File Offset: 0x001FE114
		[NullableContext(2)]
		public FKuroClothLocalCollider(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015C7E RID: 89214 RVA: 0x001FFF1E File Offset: 0x001FE11E
		public FKuroClothLocalCollider(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015C7F RID: 89215 RVA: 0x001FFF29 File Offset: 0x001FE129
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroClothLocalCollider(Pointer, false, true);
		}

		// Token: 0x06015C80 RID: 89216 RVA: 0x001FFF33 File Offset: 0x001FE133
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroClothLocalCollider(Pointer, MemoryOwner);
		}

		// Token: 0x0400BE21 RID: 48673
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroClothLocalCollider";

		// Token: 0x0400BE22 RID: 48674
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BE23 RID: 48675
		internal static int __PropertyOffset_Id;

		// Token: 0x0400BE24 RID: 48676
		internal static int __PropertyOffset_Name;

		// Token: 0x0400BE25 RID: 48677
		internal static int __PropertyOffset_Shape;

		// Token: 0x0400BE26 RID: 48678
		internal static int __PropertyOffset_Center;

		// Token: 0x0400BE27 RID: 48679
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400BE28 RID: 48680
		internal static int __PropertyOffset_HalfSize;

		// Token: 0x0400BE29 RID: 48681
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400BE2A RID: 48682
		internal static int __PropertyOffset_Height;

		// Token: 0x0400BE2B RID: 48683
		internal static int __PropertyOffset_bEnabled;
	}
}
