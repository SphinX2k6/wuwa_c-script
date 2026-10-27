using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025B8 RID: 9656
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraMaterialOverride")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNiagaraMaterialOverride : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023E25 RID: 146981 RVA: 0x00351031 File Offset: 0x0034F231
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraMaterialOverride._ScriptStructPtr != 0) ? FNiagaraMaterialOverride._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraMaterialOverride", ref FNiagaraMaterialOverride._ScriptStructPtr);
		}

		// Token: 0x170089F9 RID: 35321
		// (get) Token: 0x06023E26 RID: 146982 RVA: 0x00351055 File Offset: 0x0034F255
		// (set) Token: 0x06023E27 RID: 146983 RVA: 0x00351069 File Offset: 0x0034F269
		public unsafe UMaterialInterface Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraMaterialOverride.__PropertyOffset_Material);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraMaterialOverride.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x170089FA RID: 35322
		// (get) Token: 0x06023E28 RID: 146984 RVA: 0x0035107E File Offset: 0x0034F27E
		// (set) Token: 0x06023E29 RID: 146985 RVA: 0x0035108E File Offset: 0x0034F28E
		public unsafe uint MaterialSubIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraMaterialOverride.__PropertyOffset_MaterialSubIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraMaterialOverride.__PropertyOffset_MaterialSubIndex) = (int)value;
			}
		}

		// Token: 0x170089FB RID: 35323
		// (get) Token: 0x06023E2A RID: 146986 RVA: 0x0035109F File Offset: 0x0034F29F
		// (set) Token: 0x06023E2B RID: 146987 RVA: 0x003510B3 File Offset: 0x0034F2B3
		public unsafe UNiagaraRendererProperties EmitterRendererProperty
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraRendererProperties>(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraMaterialOverride.__PropertyOffset_EmitterRendererProperty);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraMaterialOverride.__PropertyOffset_EmitterRendererProperty, value);
			}
		}

		// Token: 0x06023E2C RID: 146988 RVA: 0x003510C8 File Offset: 0x0034F2C8
		public FNiagaraMaterialOverride()
		{
		}

		// Token: 0x06023E2D RID: 146989 RVA: 0x003510D0 File Offset: 0x0034F2D0
		[NullableContext(1)]
		public FNiagaraMaterialOverride(UMaterialInterface Material, uint MaterialSubIndex, UNiagaraRendererProperties EmitterRendererProperty)
		{
			this.Material = Material;
			this.MaterialSubIndex = MaterialSubIndex;
			this.EmitterRendererProperty = EmitterRendererProperty;
		}

		// Token: 0x06023E2E RID: 146990 RVA: 0x003510ED File Offset: 0x0034F2ED
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraMaterialOverride.StaticStruct();
		}

		// Token: 0x06023E2F RID: 146991 RVA: 0x003510F9 File Offset: 0x0034F2F9
		public FNiagaraMaterialOverride(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023E30 RID: 146992 RVA: 0x00351103 File Offset: 0x0034F303
		public FNiagaraMaterialOverride(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023E31 RID: 146993 RVA: 0x0035110E File Offset: 0x0034F30E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraMaterialOverride(Pointer, false, true);
		}

		// Token: 0x06023E32 RID: 146994 RVA: 0x00351118 File Offset: 0x0034F318
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraMaterialOverride(Pointer, MemoryOwner);
		}

		// Token: 0x040133D9 RID: 78809
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraMaterialOverride";

		// Token: 0x040133DA RID: 78810
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040133DB RID: 78811
		internal static int __PropertyOffset_Material;

		// Token: 0x040133DC RID: 78812
		internal static int __PropertyOffset_MaterialSubIndex;

		// Token: 0x040133DD RID: 78813
		internal static int __PropertyOffset_EmitterRendererProperty;
	}
}
