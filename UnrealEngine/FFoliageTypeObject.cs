using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012C9 RID: 4809
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Foliage.FoliageTypeObject")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FFoliageTypeObject : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011A5C RID: 72284 RVA: 0x0019E775 File Offset: 0x0019C975
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFoliageTypeObject._ScriptStructPtr != 0) ? FFoliageTypeObject._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Foliage.FoliageTypeObject", ref FFoliageTypeObject._ScriptStructPtr);
		}

		// Token: 0x17004511 RID: 17681
		// (get) Token: 0x06011A5D RID: 72285 RVA: 0x0019E799 File Offset: 0x0019C999
		// (set) Token: 0x06011A5E RID: 72286 RVA: 0x0019E7AD File Offset: 0x0019C9AD
		public unsafe UObject FoliageTypeObject
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FFoliageTypeObject.__PropertyOffset_FoliageTypeObject);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FFoliageTypeObject.__PropertyOffset_FoliageTypeObject, value);
			}
		}

		// Token: 0x17004512 RID: 17682
		// (get) Token: 0x06011A5F RID: 72287 RVA: 0x0019E7C2 File Offset: 0x0019C9C2
		// (set) Token: 0x06011A60 RID: 72288 RVA: 0x0019E7D6 File Offset: 0x0019C9D6
		public unsafe UFoliageType TypeInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFoliageType>(base.NativePtr / (IntPtr)sizeof(void*) + FFoliageTypeObject.__PropertyOffset_TypeInstance);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FFoliageTypeObject.__PropertyOffset_TypeInstance, value);
			}
		}

		// Token: 0x17004513 RID: 17683
		// (get) Token: 0x06011A61 RID: 72289 RVA: 0x0019E7EB File Offset: 0x0019C9EB
		// (set) Token: 0x06011A62 RID: 72290 RVA: 0x0019E7FB File Offset: 0x0019C9FB
		public unsafe bool bIsAsset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFoliageTypeObject.__PropertyOffset_bIsAsset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFoliageTypeObject.__PropertyOffset_bIsAsset) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004514 RID: 17684
		// (get) Token: 0x06011A63 RID: 72291 RVA: 0x0019E80C File Offset: 0x0019CA0C
		// (set) Token: 0x06011A64 RID: 72292 RVA: 0x0019E820 File Offset: 0x0019CA20
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UFoliageType_InstancedStaticMesh> Type_DEPRECATED
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FFoliageTypeObject.__PropertyOffset_Type_DEPRECATED);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FFoliageTypeObject.__PropertyOffset_Type_DEPRECATED) = value;
			}
		}

		// Token: 0x06011A65 RID: 72293 RVA: 0x0019E835 File Offset: 0x0019CA35
		public FFoliageTypeObject()
		{
		}

		// Token: 0x06011A66 RID: 72294 RVA: 0x0019E83D File Offset: 0x0019CA3D
		[NullableContext(1)]
		public FFoliageTypeObject(UObject FoliageTypeObject, UFoliageType TypeInstance, bool bIsAsset, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UFoliageType_InstancedStaticMesh> Type_DEPRECATED)
		{
			this.FoliageTypeObject = FoliageTypeObject;
			this.TypeInstance = TypeInstance;
			this.bIsAsset = bIsAsset;
			this.Type_DEPRECATED = Type_DEPRECATED;
		}

		// Token: 0x06011A67 RID: 72295 RVA: 0x0019E862 File Offset: 0x0019CA62
		protected override IntPtr GetUStructPtr()
		{
			return FFoliageTypeObject.StaticStruct();
		}

		// Token: 0x06011A68 RID: 72296 RVA: 0x0019E86E File Offset: 0x0019CA6E
		public FFoliageTypeObject(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011A69 RID: 72297 RVA: 0x0019E878 File Offset: 0x0019CA78
		public FFoliageTypeObject(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011A6A RID: 72298 RVA: 0x0019E883 File Offset: 0x0019CA83
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFoliageTypeObject(Pointer, false, true);
		}

		// Token: 0x06011A6B RID: 72299 RVA: 0x0019E88D File Offset: 0x0019CA8D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFoliageTypeObject(Pointer, MemoryOwner);
		}

		// Token: 0x04009776 RID: 38774
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Foliage.FoliageTypeObject";

		// Token: 0x04009777 RID: 38775
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009778 RID: 38776
		internal static int __PropertyOffset_FoliageTypeObject;

		// Token: 0x04009779 RID: 38777
		internal static int __PropertyOffset_TypeInstance;

		// Token: 0x0400977A RID: 38778
		internal static int __PropertyOffset_bIsAsset;

		// Token: 0x0400977B RID: 38779
		internal static int __PropertyOffset_Type_DEPRECATED;
	}
}
