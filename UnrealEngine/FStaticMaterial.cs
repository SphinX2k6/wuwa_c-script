using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200118F RID: 4495
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StaticMaterial")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FStaticMaterial : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010825 RID: 67621 RVA: 0x00183DA2 File Offset: 0x00181FA2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStaticMaterial._ScriptStructPtr != 0) ? FStaticMaterial._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StaticMaterial", ref FStaticMaterial._ScriptStructPtr);
		}

		// Token: 0x17004058 RID: 16472
		// (get) Token: 0x06010826 RID: 67622 RVA: 0x00183DC6 File Offset: 0x00181FC6
		// (set) Token: 0x06010827 RID: 67623 RVA: 0x00183DDA File Offset: 0x00181FDA
		[Nullable(2)]
		public unsafe UMaterialInterface MaterialInterface
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FStaticMaterial.__PropertyOffset_MaterialInterface);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FStaticMaterial.__PropertyOffset_MaterialInterface, value);
			}
		}

		// Token: 0x17004059 RID: 16473
		// (get) Token: 0x06010828 RID: 67624 RVA: 0x00183DEF File Offset: 0x00181FEF
		// (set) Token: 0x06010829 RID: 67625 RVA: 0x00183E03 File Offset: 0x00182003
		public unsafe FName MaterialSlotName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticMaterial.__PropertyOffset_MaterialSlotName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticMaterial.__PropertyOffset_MaterialSlotName) = value;
			}
		}

		// Token: 0x1700405A RID: 16474
		// (get) Token: 0x0601082A RID: 67626 RVA: 0x00183E18 File Offset: 0x00182018
		// (set) Token: 0x0601082B RID: 67627 RVA: 0x00183E2C File Offset: 0x0018202C
		public unsafe FName ImportedMaterialSlotName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticMaterial.__PropertyOffset_ImportedMaterialSlotName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticMaterial.__PropertyOffset_ImportedMaterialSlotName) = value;
			}
		}

		// Token: 0x1700405B RID: 16475
		// (get) Token: 0x0601082C RID: 67628 RVA: 0x00183E44 File Offset: 0x00182044
		// (set) Token: 0x0601082D RID: 67629 RVA: 0x00183E87 File Offset: 0x00182087
		public FMeshUVChannelInfo UVChannelData
		{
			get
			{
				base.FastCheckIsValid();
				FMeshUVChannelInfo result;
				if ((result = this._UVChannelData) == null)
				{
					result = (this._UVChannelData = new FMeshUVChannelInfo(base.NativePtr + (IntPtr)FStaticMaterial.__PropertyOffset_UVChannelData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMeshUVChannelInfo.StaticStruct(), base.NativePtr + (IntPtr)FStaticMaterial.__PropertyOffset_UVChannelData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601082E RID: 67630 RVA: 0x00183EA8 File Offset: 0x001820A8
		public FStaticMaterial()
		{
		}

		// Token: 0x0601082F RID: 67631 RVA: 0x00183EB0 File Offset: 0x001820B0
		public FStaticMaterial(UMaterialInterface MaterialInterface, FName MaterialSlotName, FName ImportedMaterialSlotName, FMeshUVChannelInfo UVChannelData)
		{
			this.MaterialInterface = MaterialInterface;
			this.MaterialSlotName = MaterialSlotName;
			this.ImportedMaterialSlotName = ImportedMaterialSlotName;
			this.UVChannelData = UVChannelData;
		}

		// Token: 0x06010830 RID: 67632 RVA: 0x00183ED5 File Offset: 0x001820D5
		protected override IntPtr GetUStructPtr()
		{
			return FStaticMaterial.StaticStruct();
		}

		// Token: 0x06010831 RID: 67633 RVA: 0x00183EE1 File Offset: 0x001820E1
		[NullableContext(2)]
		public FStaticMaterial(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010832 RID: 67634 RVA: 0x00183EEB File Offset: 0x001820EB
		public FStaticMaterial(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010833 RID: 67635 RVA: 0x00183EF6 File Offset: 0x001820F6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStaticMaterial(Pointer, false, true);
		}

		// Token: 0x06010834 RID: 67636 RVA: 0x00183F00 File Offset: 0x00182100
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStaticMaterial(Pointer, MemoryOwner);
		}

		// Token: 0x04008D47 RID: 36167
		public const string __ObjectPath = "/Script/Engine.StaticMaterial";

		// Token: 0x04008D48 RID: 36168
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008D49 RID: 36169
		internal static int __PropertyOffset_MaterialInterface;

		// Token: 0x04008D4A RID: 36170
		internal static int __PropertyOffset_MaterialSlotName;

		// Token: 0x04008D4B RID: 36171
		internal static int __PropertyOffset_ImportedMaterialSlotName;

		// Token: 0x04008D4C RID: 36172
		internal static int __PropertyOffset_UVChannelData;

		// Token: 0x04008D4D RID: 36173
		[Nullable(2)]
		private FMeshUVChannelInfo _UVChannelData;
	}
}
