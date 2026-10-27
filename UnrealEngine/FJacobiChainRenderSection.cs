using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200178F RID: 6031
	[UnrealObjectPath("/Script/KuroComputeShader.JacobiChainRenderSection")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FJacobiChainRenderSection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015B6A RID: 88938 RVA: 0x001FE915 File Offset: 0x001FCB15
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJacobiChainRenderSection._ScriptStructPtr != 0) ? FJacobiChainRenderSection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.JacobiChainRenderSection", ref FJacobiChainRenderSection._ScriptStructPtr);
		}

		// Token: 0x170055E8 RID: 21992
		// (get) Token: 0x06015B6B RID: 88939 RVA: 0x001FE939 File Offset: 0x001FCB39
		// (set) Token: 0x06015B6C RID: 88940 RVA: 0x001FE949 File Offset: 0x001FCB49
		public unsafe uint FirstIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRenderSection.__PropertyOffset_FirstIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRenderSection.__PropertyOffset_FirstIndex) = (int)value;
			}
		}

		// Token: 0x170055E9 RID: 21993
		// (get) Token: 0x06015B6D RID: 88941 RVA: 0x001FE95A File Offset: 0x001FCB5A
		// (set) Token: 0x06015B6E RID: 88942 RVA: 0x001FE96A File Offset: 0x001FCB6A
		public unsafe uint NumTriangles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRenderSection.__PropertyOffset_NumTriangles);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRenderSection.__PropertyOffset_NumTriangles) = (int)value;
			}
		}

		// Token: 0x170055EA RID: 21994
		// (get) Token: 0x06015B6F RID: 88943 RVA: 0x001FE97B File Offset: 0x001FCB7B
		// (set) Token: 0x06015B70 RID: 88944 RVA: 0x001FE98B File Offset: 0x001FCB8B
		public unsafe int MaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRenderSection.__PropertyOffset_MaterialIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRenderSection.__PropertyOffset_MaterialIndex) = value;
			}
		}

		// Token: 0x06015B71 RID: 88945 RVA: 0x001FE99C File Offset: 0x001FCB9C
		public FJacobiChainRenderSection()
		{
		}

		// Token: 0x06015B72 RID: 88946 RVA: 0x001FE9A4 File Offset: 0x001FCBA4
		public FJacobiChainRenderSection(uint FirstIndex, uint NumTriangles, int MaterialIndex)
		{
			this.FirstIndex = FirstIndex;
			this.NumTriangles = NumTriangles;
			this.MaterialIndex = MaterialIndex;
		}

		// Token: 0x06015B73 RID: 88947 RVA: 0x001FE9C1 File Offset: 0x001FCBC1
		protected override IntPtr GetUStructPtr()
		{
			return FJacobiChainRenderSection.StaticStruct();
		}

		// Token: 0x06015B74 RID: 88948 RVA: 0x001FE9CD File Offset: 0x001FCBCD
		[NullableContext(2)]
		public FJacobiChainRenderSection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015B75 RID: 88949 RVA: 0x001FE9D7 File Offset: 0x001FCBD7
		public FJacobiChainRenderSection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015B76 RID: 88950 RVA: 0x001FE9E2 File Offset: 0x001FCBE2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FJacobiChainRenderSection(Pointer, false, true);
		}

		// Token: 0x06015B77 RID: 88951 RVA: 0x001FE9EC File Offset: 0x001FCBEC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FJacobiChainRenderSection(Pointer, MemoryOwner);
		}

		// Token: 0x0400BDAD RID: 48557
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.JacobiChainRenderSection";

		// Token: 0x0400BDAE RID: 48558
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BDAF RID: 48559
		internal static int __PropertyOffset_FirstIndex;

		// Token: 0x0400BDB0 RID: 48560
		internal static int __PropertyOffset_NumTriangles;

		// Token: 0x0400BDB1 RID: 48561
		internal static int __PropertyOffset_MaterialIndex;
	}
}
