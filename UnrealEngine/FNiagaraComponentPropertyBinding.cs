using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002545 RID: 9541
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraComponentPropertyBinding")]
	[UnrealStructLayout(400, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 400)]
	public class FNiagaraComponentPropertyBinding : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023750 RID: 145232 RVA: 0x0034693A File Offset: 0x00344B3A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraComponentPropertyBinding._ScriptStructPtr != 0) ? FNiagaraComponentPropertyBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraComponentPropertyBinding", ref FNiagaraComponentPropertyBinding._ScriptStructPtr);
		}

		// Token: 0x1700882A RID: 34858
		// (get) Token: 0x06023751 RID: 145233 RVA: 0x00346960 File Offset: 0x00344B60
		// (set) Token: 0x06023752 RID: 145234 RVA: 0x003469A3 File Offset: 0x00344BA3
		public FNiagaraVariableAttributeBinding AttributeBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._AttributeBinding) == null)
				{
					result = (this._AttributeBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)FNiagaraComponentPropertyBinding.__PropertyOffset_AttributeBinding, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraComponentPropertyBinding.__PropertyOffset_AttributeBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700882B RID: 34859
		// (get) Token: 0x06023753 RID: 145235 RVA: 0x003469C4 File Offset: 0x00344BC4
		// (set) Token: 0x06023754 RID: 145236 RVA: 0x003469D8 File Offset: 0x00344BD8
		public unsafe FName PropertyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraComponentPropertyBinding.__PropertyOffset_PropertyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraComponentPropertyBinding.__PropertyOffset_PropertyName) = value;
			}
		}

		// Token: 0x1700882C RID: 34860
		// (get) Token: 0x06023755 RID: 145237 RVA: 0x003469F0 File Offset: 0x00344BF0
		// (set) Token: 0x06023756 RID: 145238 RVA: 0x00346A33 File Offset: 0x00344C33
		public FNiagaraTypeDefinition PropertyType
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraTypeDefinition result;
				if ((result = this._PropertyType) == null)
				{
					result = (this._PropertyType = new FNiagaraTypeDefinition(base.NativePtr + (IntPtr)FNiagaraComponentPropertyBinding.__PropertyOffset_PropertyType, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraTypeDefinition.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraComponentPropertyBinding.__PropertyOffset_PropertyType, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700882D RID: 34861
		// (get) Token: 0x06023757 RID: 145239 RVA: 0x00346A54 File Offset: 0x00344C54
		// (set) Token: 0x06023758 RID: 145240 RVA: 0x00346A68 File Offset: 0x00344C68
		public unsafe FName MetadataSetterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraComponentPropertyBinding.__PropertyOffset_MetadataSetterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraComponentPropertyBinding.__PropertyOffset_MetadataSetterName) = value;
			}
		}

		// Token: 0x1700882E RID: 34862
		// (get) Token: 0x06023759 RID: 145241 RVA: 0x00346A80 File Offset: 0x00344C80
		// (set) Token: 0x0602375A RID: 145242 RVA: 0x00346AC3 File Offset: 0x00344CC3
		public FNiagaraVariable WritableValue
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariable result;
				if ((result = this._WritableValue) == null)
				{
					result = (this._WritableValue = new FNiagaraVariable(base.NativePtr + (IntPtr)FNiagaraComponentPropertyBinding.__PropertyOffset_WritableValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariable.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraComponentPropertyBinding.__PropertyOffset_WritableValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602375B RID: 145243 RVA: 0x00346AE4 File Offset: 0x00344CE4
		public FNiagaraComponentPropertyBinding()
		{
		}

		// Token: 0x0602375C RID: 145244 RVA: 0x00346AEC File Offset: 0x00344CEC
		public FNiagaraComponentPropertyBinding(FNiagaraVariableAttributeBinding AttributeBinding, FName PropertyName, FNiagaraTypeDefinition PropertyType, FName MetadataSetterName, FNiagaraVariable WritableValue)
		{
			this.AttributeBinding = AttributeBinding;
			this.PropertyName = PropertyName;
			this.PropertyType = PropertyType;
			this.MetadataSetterName = MetadataSetterName;
			this.WritableValue = WritableValue;
		}

		// Token: 0x0602375D RID: 145245 RVA: 0x00346B19 File Offset: 0x00344D19
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraComponentPropertyBinding.StaticStruct();
		}

		// Token: 0x0602375E RID: 145246 RVA: 0x00346B25 File Offset: 0x00344D25
		[NullableContext(2)]
		public FNiagaraComponentPropertyBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602375F RID: 145247 RVA: 0x00346B2F File Offset: 0x00344D2F
		public FNiagaraComponentPropertyBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023760 RID: 145248 RVA: 0x00346B3A File Offset: 0x00344D3A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraComponentPropertyBinding(Pointer, false, true);
		}

		// Token: 0x06023761 RID: 145249 RVA: 0x00346B44 File Offset: 0x00344D44
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraComponentPropertyBinding(Pointer, MemoryOwner);
		}

		// Token: 0x0401302A RID: 77866
		public const string __ObjectPath = "/Script/Niagara.NiagaraComponentPropertyBinding";

		// Token: 0x0401302B RID: 77867
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401302C RID: 77868
		internal static int __PropertyOffset_AttributeBinding;

		// Token: 0x0401302D RID: 77869
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _AttributeBinding;

		// Token: 0x0401302E RID: 77870
		internal static int __PropertyOffset_PropertyName;

		// Token: 0x0401302F RID: 77871
		internal static int __PropertyOffset_PropertyType;

		// Token: 0x04013030 RID: 77872
		[Nullable(2)]
		private FNiagaraTypeDefinition _PropertyType;

		// Token: 0x04013031 RID: 77873
		internal static int __PropertyOffset_MetadataSetterName;

		// Token: 0x04013032 RID: 77874
		internal static int __PropertyOffset_WritableValue;

		// Token: 0x04013033 RID: 77875
		[Nullable(2)]
		private FNiagaraVariable _WritableValue;
	}
}
