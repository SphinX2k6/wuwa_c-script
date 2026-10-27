using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009AE RID: 2478
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DefaultPawn")]
	[UnrealStructLayout(1176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1176)]
	public class ADefaultPawn : APawn, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008C28 RID: 35880 RVA: 0x000C8A25 File Offset: 0x000C6C25
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ADefaultPawn._ClassPtr;
		}

		// Token: 0x06008C29 RID: 35881 RVA: 0x000C8A34 File Offset: 0x000C6C34
		public ADefaultPawn() : this(BuiltinUtils.AllocNativeUObject(ADefaultPawn.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008C2A RID: 35882 RVA: 0x000C8A5C File Offset: 0x000C6C5C
		[NullableContext(1)]
		public ADefaultPawn(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ADefaultPawn.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170020FB RID: 8443
		// (get) Token: 0x06008C2B RID: 35883 RVA: 0x000C8A8F File Offset: 0x000C6C8F
		// (set) Token: 0x06008C2C RID: 35884 RVA: 0x000C8A9F File Offset: 0x000C6C9F
		public unsafe float BaseTurnRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ADefaultPawn.__PropertyOffset_BaseTurnRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ADefaultPawn.__PropertyOffset_BaseTurnRate) = value;
			}
		}

		// Token: 0x170020FC RID: 8444
		// (get) Token: 0x06008C2D RID: 35885 RVA: 0x000C8AB0 File Offset: 0x000C6CB0
		// (set) Token: 0x06008C2E RID: 35886 RVA: 0x000C8AC0 File Offset: 0x000C6CC0
		public unsafe float BaseLookUpRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ADefaultPawn.__PropertyOffset_BaseLookUpRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ADefaultPawn.__PropertyOffset_BaseLookUpRate) = value;
			}
		}

		// Token: 0x170020FD RID: 8445
		// (get) Token: 0x06008C2F RID: 35887 RVA: 0x000C8AD1 File Offset: 0x000C6CD1
		// (set) Token: 0x06008C30 RID: 35888 RVA: 0x000C8AE5 File Offset: 0x000C6CE5
		public unsafe UPawnMovementComponent MovementComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPawnMovementComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ADefaultPawn.__PropertyOffset_MovementComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ADefaultPawn.__PropertyOffset_MovementComponent, value);
			}
		}

		// Token: 0x170020FE RID: 8446
		// (get) Token: 0x06008C31 RID: 35889 RVA: 0x000C8AFA File Offset: 0x000C6CFA
		// (set) Token: 0x06008C32 RID: 35890 RVA: 0x000C8B0E File Offset: 0x000C6D0E
		public unsafe USphereComponent CollisionComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ADefaultPawn.__PropertyOffset_CollisionComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ADefaultPawn.__PropertyOffset_CollisionComponent, value);
			}
		}

		// Token: 0x170020FF RID: 8447
		// (get) Token: 0x06008C33 RID: 35891 RVA: 0x000C8B23 File Offset: 0x000C6D23
		// (set) Token: 0x06008C34 RID: 35892 RVA: 0x000C8B37 File Offset: 0x000C6D37
		public unsafe UStaticMeshComponent MeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ADefaultPawn.__PropertyOffset_MeshComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ADefaultPawn.__PropertyOffset_MeshComponent, value);
			}
		}

		// Token: 0x17002100 RID: 8448
		// (get) Token: 0x06008C35 RID: 35893 RVA: 0x000C8B4C File Offset: 0x000C6D4C
		// (set) Token: 0x06008C36 RID: 35894 RVA: 0x000C8B65 File Offset: 0x000C6D65
		public unsafe bool bAddDefaultMovementBindings
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ADefaultPawn.__PropertyOffset_bAddDefaultMovementBindings) & ADefaultPawn.__PropertyMask_bAddDefaultMovementBindings) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ADefaultPawn.__PropertyOffset_bAddDefaultMovementBindings) = ((*(base.NativePtr + (IntPtr)ADefaultPawn.__PropertyOffset_bAddDefaultMovementBindings) & ~ADefaultPawn.__PropertyMask_bAddDefaultMovementBindings) | (value ? ADefaultPawn.__PropertyMask_bAddDefaultMovementBindings : 0));
			}
		}

		// Token: 0x06008C37 RID: 35895 RVA: 0x000C8B95 File Offset: 0x000C6D95
		public void TurnAtRate(float Rate)
		{
			ADefaultPawn.__TurnAtRate_Internal(base.NativePtr, Rate);
		}

		// Token: 0x06008C38 RID: 35896 RVA: 0x000C8BA3 File Offset: 0x000C6DA3
		public void MoveUp_World(float Val)
		{
			ADefaultPawn.__MoveUp_World_Internal(base.NativePtr, Val);
		}

		// Token: 0x06008C39 RID: 35897 RVA: 0x000C8BB1 File Offset: 0x000C6DB1
		public void MoveRight(float Val)
		{
			ADefaultPawn.__MoveRight_Internal(base.NativePtr, Val);
		}

		// Token: 0x06008C3A RID: 35898 RVA: 0x000C8BBF File Offset: 0x000C6DBF
		public void MoveForward(float Val)
		{
			ADefaultPawn.__MoveForward_Internal(base.NativePtr, Val);
		}

		// Token: 0x06008C3B RID: 35899 RVA: 0x000C8BCD File Offset: 0x000C6DCD
		public void LookUpAtRate(float Rate)
		{
			ADefaultPawn.__LookUpAtRate_Internal(base.NativePtr, Rate);
		}

		// Token: 0x06008C3C RID: 35900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TurnAtRate_Internal(IntPtr @this, float Rate);

		// Token: 0x06008C3D RID: 35901
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MoveUp_World_Internal(IntPtr @this, float Val);

		// Token: 0x06008C3E RID: 35902
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MoveRight_Internal(IntPtr @this, float Val);

		// Token: 0x06008C3F RID: 35903
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MoveForward_Internal(IntPtr @this, float Val);

		// Token: 0x06008C40 RID: 35904
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LookUpAtRate_Internal(IntPtr @this, float Rate);

		// Token: 0x06008C41 RID: 35905 RVA: 0x000C8BDB File Offset: 0x000C6DDB
		static ADefaultPawn()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DefaultPawn");
		}

		// Token: 0x06008C42 RID: 35906 RVA: 0x000C8BE9 File Offset: 0x000C6DE9
		protected ADefaultPawn(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004288 RID: 17032
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DefaultPawn";

		// Token: 0x04004289 RID: 17033
		private static IntPtr _ClassPtr;

		// Token: 0x0400428A RID: 17034
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400428B RID: 17035
		internal static int __PropertyOffset_BaseTurnRate;

		// Token: 0x0400428C RID: 17036
		internal static int __PropertyOffset_BaseLookUpRate;

		// Token: 0x0400428D RID: 17037
		internal static int __PropertyOffset_MovementComponent;

		// Token: 0x0400428E RID: 17038
		internal static int __PropertyOffset_CollisionComponent;

		// Token: 0x0400428F RID: 17039
		internal static int __PropertyOffset_MeshComponent;

		// Token: 0x04004290 RID: 17040
		internal static int __PropertyOffset_bAddDefaultMovementBindings;

		// Token: 0x04004291 RID: 17041
		internal static byte __PropertyMask_bAddDefaultMovementBindings;
	}
}
