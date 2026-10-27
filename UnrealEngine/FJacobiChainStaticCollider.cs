using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001793 RID: 6035
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.JacobiChainStaticCollider")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FJacobiChainStaticCollider : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015BB8 RID: 89016 RVA: 0x001FEEE0 File Offset: 0x001FD0E0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJacobiChainStaticCollider._ScriptStructPtr != 0) ? FJacobiChainStaticCollider._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.JacobiChainStaticCollider", ref FJacobiChainStaticCollider._ScriptStructPtr);
		}

		// Token: 0x170055FF RID: 22015
		// (get) Token: 0x06015BB9 RID: 89017 RVA: 0x001FEF04 File Offset: 0x001FD104
		// (set) Token: 0x06015BBA RID: 89018 RVA: 0x001FEF18 File Offset: 0x001FD118
		public unsafe string Id
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FJacobiChainStaticCollider.__PropertyOffset_Id)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FJacobiChainStaticCollider.__PropertyOffset_Id)), value);
			}
		}

		// Token: 0x17005600 RID: 22016
		// (get) Token: 0x06015BBB RID: 89019 RVA: 0x001FEF2D File Offset: 0x001FD12D
		// (set) Token: 0x06015BBC RID: 89020 RVA: 0x001FEF41 File Offset: 0x001FD141
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FJacobiChainStaticCollider.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FJacobiChainStaticCollider.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17005601 RID: 22017
		// (get) Token: 0x06015BBD RID: 89021 RVA: 0x001FEF56 File Offset: 0x001FD156
		// (set) Token: 0x06015BBE RID: 89022 RVA: 0x001FEF66 File Offset: 0x001FD166
		public unsafe EJacobiChainStaticColliderType Type
		{
			get
			{
				return (EJacobiChainStaticColliderType)(*(base.NativePtr + (IntPtr)FJacobiChainStaticCollider.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainStaticCollider.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17005602 RID: 22018
		// (get) Token: 0x06015BBF RID: 89023 RVA: 0x001FEF77 File Offset: 0x001FD177
		// (set) Token: 0x06015BC0 RID: 89024 RVA: 0x001FEF8B File Offset: 0x001FD18B
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainStaticCollider.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainStaticCollider.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x17005603 RID: 22019
		// (get) Token: 0x06015BC1 RID: 89025 RVA: 0x001FEFA0 File Offset: 0x001FD1A0
		// (set) Token: 0x06015BC2 RID: 89026 RVA: 0x001FEFB4 File Offset: 0x001FD1B4
		public unsafe FVector Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainStaticCollider.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainStaticCollider.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17005604 RID: 22020
		// (get) Token: 0x06015BC3 RID: 89027 RVA: 0x001FEFC9 File Offset: 0x001FD1C9
		// (set) Token: 0x06015BC4 RID: 89028 RVA: 0x001FEFDD File Offset: 0x001FD1DD
		public unsafe FVector HalfSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainStaticCollider.__PropertyOffset_HalfSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainStaticCollider.__PropertyOffset_HalfSize) = value;
			}
		}

		// Token: 0x17005605 RID: 22021
		// (get) Token: 0x06015BC5 RID: 89029 RVA: 0x001FEFF2 File Offset: 0x001FD1F2
		// (set) Token: 0x06015BC6 RID: 89030 RVA: 0x001FF002 File Offset: 0x001FD202
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainStaticCollider.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainStaticCollider.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06015BC7 RID: 89031 RVA: 0x001FF013 File Offset: 0x001FD213
		public FJacobiChainStaticCollider()
		{
		}

		// Token: 0x06015BC8 RID: 89032 RVA: 0x001FF01B File Offset: 0x001FD21B
		public FJacobiChainStaticCollider(string Id, string Name, EJacobiChainStaticColliderType Type, FVector Center, FVector Rotation, FVector HalfSize, bool bEnabled)
		{
			this.Id = Id;
			this.Name = Name;
			this.Type = Type;
			this.Center = Center;
			this.Rotation = Rotation;
			this.HalfSize = HalfSize;
			this.bEnabled = bEnabled;
		}

		// Token: 0x06015BC9 RID: 89033 RVA: 0x001FF058 File Offset: 0x001FD258
		protected override IntPtr GetUStructPtr()
		{
			return FJacobiChainStaticCollider.StaticStruct();
		}

		// Token: 0x06015BCA RID: 89034 RVA: 0x001FF064 File Offset: 0x001FD264
		[NullableContext(2)]
		public FJacobiChainStaticCollider(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015BCB RID: 89035 RVA: 0x001FF06E File Offset: 0x001FD26E
		public FJacobiChainStaticCollider(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015BCC RID: 89036 RVA: 0x001FF079 File Offset: 0x001FD279
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FJacobiChainStaticCollider(Pointer, false, true);
		}

		// Token: 0x06015BCD RID: 89037 RVA: 0x001FF083 File Offset: 0x001FD283
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FJacobiChainStaticCollider(Pointer, MemoryOwner);
		}

		// Token: 0x0400BDCD RID: 48589
		public const string __ObjectPath = "/Script/KuroComputeShader.JacobiChainStaticCollider";

		// Token: 0x0400BDCE RID: 48590
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BDCF RID: 48591
		internal static int __PropertyOffset_Id;

		// Token: 0x0400BDD0 RID: 48592
		internal static int __PropertyOffset_Name;

		// Token: 0x0400BDD1 RID: 48593
		internal static int __PropertyOffset_Type;

		// Token: 0x0400BDD2 RID: 48594
		internal static int __PropertyOffset_Center;

		// Token: 0x0400BDD3 RID: 48595
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400BDD4 RID: 48596
		internal static int __PropertyOffset_HalfSize;

		// Token: 0x0400BDD5 RID: 48597
		internal static int __PropertyOffset_bEnabled;
	}
}
