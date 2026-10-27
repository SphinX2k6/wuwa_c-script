using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027B9 RID: 10169
	[UnrealObjectPath("/Script/SimplygonUObjects.InputMaterialSettings")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FInputMaterialSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025E98 RID: 155288 RVA: 0x00397A40 File Offset: 0x00395C40
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputMaterialSettings._ScriptStructPtr != 0) ? FInputMaterialSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.InputMaterialSettings", ref FInputMaterialSettings._ScriptStructPtr);
		}

		// Token: 0x1700922A RID: 37418
		// (get) Token: 0x06025E99 RID: 155289 RVA: 0x00397A64 File Offset: 0x00395C64
		// (set) Token: 0x06025E9A RID: 155290 RVA: 0x00397A74 File Offset: 0x00395C74
		public unsafe int MaterialMapping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputMaterialSettings.__PropertyOffset_MaterialMapping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputMaterialSettings.__PropertyOffset_MaterialMapping) = value;
			}
		}

		// Token: 0x06025E9B RID: 155291 RVA: 0x00397A85 File Offset: 0x00395C85
		public FInputMaterialSettings()
		{
		}

		// Token: 0x06025E9C RID: 155292 RVA: 0x00397A8D File Offset: 0x00395C8D
		public FInputMaterialSettings(int MaterialMapping)
		{
			this.MaterialMapping = MaterialMapping;
		}

		// Token: 0x06025E9D RID: 155293 RVA: 0x00397A9C File Offset: 0x00395C9C
		protected override IntPtr GetUStructPtr()
		{
			return FInputMaterialSettings.StaticStruct();
		}

		// Token: 0x06025E9E RID: 155294 RVA: 0x00397AA8 File Offset: 0x00395CA8
		[NullableContext(2)]
		public FInputMaterialSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025E9F RID: 155295 RVA: 0x00397AB2 File Offset: 0x00395CB2
		public FInputMaterialSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025EA0 RID: 155296 RVA: 0x00397ABD File Offset: 0x00395CBD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputMaterialSettings(Pointer, false, true);
		}

		// Token: 0x06025EA1 RID: 155297 RVA: 0x00397AC7 File Offset: 0x00395CC7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputMaterialSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014B11 RID: 84753
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SimplygonUObjects.InputMaterialSettings";

		// Token: 0x04014B12 RID: 84754
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014B13 RID: 84755
		internal static int __PropertyOffset_MaterialMapping;
	}
}
