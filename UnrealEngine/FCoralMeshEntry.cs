using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A61 RID: 6753
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.CoralMeshEntry")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FCoralMeshEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019006 RID: 102406 RVA: 0x0024F3AB File Offset: 0x0024D5AB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCoralMeshEntry._ScriptStructPtr != 0) ? FCoralMeshEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.CoralMeshEntry", ref FCoralMeshEntry._ScriptStructPtr);
		}

		// Token: 0x1700631D RID: 25373
		// (get) Token: 0x06019007 RID: 102407 RVA: 0x0024F3CF File Offset: 0x0024D5CF
		// (set) Token: 0x06019008 RID: 102408 RVA: 0x0024F3E3 File Offset: 0x0024D5E3
		public unsafe UStaticMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FCoralMeshEntry.__PropertyOffset_Mesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCoralMeshEntry.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x1700631E RID: 25374
		// (get) Token: 0x06019009 RID: 102409 RVA: 0x0024F3F8 File Offset: 0x0024D5F8
		// (set) Token: 0x0601900A RID: 102410 RVA: 0x0024F40C File Offset: 0x0024D60C
		public unsafe UTexture2D RestSpineTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FCoralMeshEntry.__PropertyOffset_RestSpineTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCoralMeshEntry.__PropertyOffset_RestSpineTexture, value);
			}
		}

		// Token: 0x1700631F RID: 25375
		// (get) Token: 0x0601900B RID: 102411 RVA: 0x0024F421 File Offset: 0x0024D621
		// (set) Token: 0x0601900C RID: 102412 RVA: 0x0024F431 File Offset: 0x0024D631
		public unsafe int StrandCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCoralMeshEntry.__PropertyOffset_StrandCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCoralMeshEntry.__PropertyOffset_StrandCount) = value;
			}
		}

		// Token: 0x17006320 RID: 25376
		// (get) Token: 0x0601900D RID: 102413 RVA: 0x0024F442 File Offset: 0x0024D642
		// (set) Token: 0x0601900E RID: 102414 RVA: 0x0024F452 File Offset: 0x0024D652
		public unsafe int NodeCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCoralMeshEntry.__PropertyOffset_NodeCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCoralMeshEntry.__PropertyOffset_NodeCount) = value;
			}
		}

		// Token: 0x0601900F RID: 102415 RVA: 0x0024F463 File Offset: 0x0024D663
		public FCoralMeshEntry()
		{
		}

		// Token: 0x06019010 RID: 102416 RVA: 0x0024F46B File Offset: 0x0024D66B
		[NullableContext(1)]
		public FCoralMeshEntry(UStaticMesh Mesh, UTexture2D RestSpineTexture, int StrandCount, int NodeCount)
		{
			this.Mesh = Mesh;
			this.RestSpineTexture = RestSpineTexture;
			this.StrandCount = StrandCount;
			this.NodeCount = NodeCount;
		}

		// Token: 0x06019011 RID: 102417 RVA: 0x0024F490 File Offset: 0x0024D690
		protected override IntPtr GetUStructPtr()
		{
			return FCoralMeshEntry.StaticStruct();
		}

		// Token: 0x06019012 RID: 102418 RVA: 0x0024F49C File Offset: 0x0024D69C
		public FCoralMeshEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019013 RID: 102419 RVA: 0x0024F4A6 File Offset: 0x0024D6A6
		public FCoralMeshEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019014 RID: 102420 RVA: 0x0024F4B1 File Offset: 0x0024D6B1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCoralMeshEntry(Pointer, false, true);
		}

		// Token: 0x06019015 RID: 102421 RVA: 0x0024F4BB File Offset: 0x0024D6BB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCoralMeshEntry(Pointer, MemoryOwner);
		}

		// Token: 0x0400D868 RID: 55400
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.CoralMeshEntry";

		// Token: 0x0400D869 RID: 55401
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D86A RID: 55402
		internal static int __PropertyOffset_Mesh;

		// Token: 0x0400D86B RID: 55403
		internal static int __PropertyOffset_RestSpineTexture;

		// Token: 0x0400D86C RID: 55404
		internal static int __PropertyOffset_StrandCount;

		// Token: 0x0400D86D RID: 55405
		internal static int __PropertyOffset_NodeCount;
	}
}
