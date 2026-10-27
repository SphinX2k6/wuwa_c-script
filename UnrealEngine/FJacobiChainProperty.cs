using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200178E RID: 6030
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.JacobiChainProperty")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FJacobiChainProperty : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015B56 RID: 88918 RVA: 0x001FE79A File Offset: 0x001FC99A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJacobiChainProperty._ScriptStructPtr != 0) ? FJacobiChainProperty._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.JacobiChainProperty", ref FJacobiChainProperty._ScriptStructPtr);
		}

		// Token: 0x170055E2 RID: 21986
		// (get) Token: 0x06015B57 RID: 88919 RVA: 0x001FE7BE File Offset: 0x001FC9BE
		// (set) Token: 0x06015B58 RID: 88920 RVA: 0x001FE7D2 File Offset: 0x001FC9D2
		public unsafe string Id
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FJacobiChainProperty.__PropertyOffset_Id)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FJacobiChainProperty.__PropertyOffset_Id)), value);
			}
		}

		// Token: 0x170055E3 RID: 21987
		// (get) Token: 0x06015B59 RID: 88921 RVA: 0x001FE7E7 File Offset: 0x001FC9E7
		// (set) Token: 0x06015B5A RID: 88922 RVA: 0x001FE7FB File Offset: 0x001FC9FB
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FJacobiChainProperty.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FJacobiChainProperty.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x170055E4 RID: 21988
		// (get) Token: 0x06015B5B RID: 88923 RVA: 0x001FE810 File Offset: 0x001FCA10
		// (set) Token: 0x06015B5C RID: 88924 RVA: 0x001FE824 File Offset: 0x001FCA24
		public unsafe FColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainProperty.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainProperty.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x170055E5 RID: 21989
		// (get) Token: 0x06015B5D RID: 88925 RVA: 0x001FE839 File Offset: 0x001FCA39
		// (set) Token: 0x06015B5E RID: 88926 RVA: 0x001FE849 File Offset: 0x001FCA49
		public unsafe bool bRigid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainProperty.__PropertyOffset_bRigid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainProperty.__PropertyOffset_bRigid) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055E6 RID: 21990
		// (get) Token: 0x06015B5F RID: 88927 RVA: 0x001FE85A File Offset: 0x001FCA5A
		// (set) Token: 0x06015B60 RID: 88928 RVA: 0x001FE86A File Offset: 0x001FCA6A
		public unsafe int ParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainProperty.__PropertyOffset_ParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainProperty.__PropertyOffset_ParticleCount) = value;
			}
		}

		// Token: 0x170055E7 RID: 21991
		// (get) Token: 0x06015B61 RID: 88929 RVA: 0x001FE87B File Offset: 0x001FCA7B
		// (set) Token: 0x06015B62 RID: 88930 RVA: 0x001FE88F File Offset: 0x001FCA8F
		public unsafe FVector CollisionBoxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainProperty.__PropertyOffset_CollisionBoxSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainProperty.__PropertyOffset_CollisionBoxSize) = value;
			}
		}

		// Token: 0x06015B63 RID: 88931 RVA: 0x001FE8A4 File Offset: 0x001FCAA4
		public FJacobiChainProperty()
		{
		}

		// Token: 0x06015B64 RID: 88932 RVA: 0x001FE8AC File Offset: 0x001FCAAC
		public FJacobiChainProperty(string Id, string Name, FColor Color, bool bRigid, int ParticleCount, FVector CollisionBoxSize)
		{
			this.Id = Id;
			this.Name = Name;
			this.Color = Color;
			this.bRigid = bRigid;
			this.ParticleCount = ParticleCount;
			this.CollisionBoxSize = CollisionBoxSize;
		}

		// Token: 0x06015B65 RID: 88933 RVA: 0x001FE8E1 File Offset: 0x001FCAE1
		protected override IntPtr GetUStructPtr()
		{
			return FJacobiChainProperty.StaticStruct();
		}

		// Token: 0x06015B66 RID: 88934 RVA: 0x001FE8ED File Offset: 0x001FCAED
		[NullableContext(2)]
		public FJacobiChainProperty(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015B67 RID: 88935 RVA: 0x001FE8F7 File Offset: 0x001FCAF7
		public FJacobiChainProperty(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015B68 RID: 88936 RVA: 0x001FE902 File Offset: 0x001FCB02
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FJacobiChainProperty(Pointer, false, true);
		}

		// Token: 0x06015B69 RID: 88937 RVA: 0x001FE90C File Offset: 0x001FCB0C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FJacobiChainProperty(Pointer, MemoryOwner);
		}

		// Token: 0x0400BDA5 RID: 48549
		public const string __ObjectPath = "/Script/KuroComputeShader.JacobiChainProperty";

		// Token: 0x0400BDA6 RID: 48550
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BDA7 RID: 48551
		internal static int __PropertyOffset_Id;

		// Token: 0x0400BDA8 RID: 48552
		internal static int __PropertyOffset_Name;

		// Token: 0x0400BDA9 RID: 48553
		internal static int __PropertyOffset_Color;

		// Token: 0x0400BDAA RID: 48554
		internal static int __PropertyOffset_bRigid;

		// Token: 0x0400BDAB RID: 48555
		internal static int __PropertyOffset_ParticleCount;

		// Token: 0x0400BDAC RID: 48556
		internal static int __PropertyOffset_CollisionBoxSize;
	}
}
