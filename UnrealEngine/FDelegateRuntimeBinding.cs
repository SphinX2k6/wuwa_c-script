using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200294C RID: 10572
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.DelegateRuntimeBinding")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FDelegateRuntimeBinding : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027249 RID: 160329 RVA: 0x003BADE9 File Offset: 0x003B8FE9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDelegateRuntimeBinding._ScriptStructPtr != 0) ? FDelegateRuntimeBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.DelegateRuntimeBinding", ref FDelegateRuntimeBinding._ScriptStructPtr);
		}

		// Token: 0x1700968F RID: 38543
		// (get) Token: 0x0602724A RID: 160330 RVA: 0x003BAE0D File Offset: 0x003B900D
		// (set) Token: 0x0602724B RID: 160331 RVA: 0x003BAE21 File Offset: 0x003B9021
		public unsafe string ObjectName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FDelegateRuntimeBinding.__PropertyOffset_ObjectName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FDelegateRuntimeBinding.__PropertyOffset_ObjectName)), value);
			}
		}

		// Token: 0x17009690 RID: 38544
		// (get) Token: 0x0602724C RID: 160332 RVA: 0x003BAE36 File Offset: 0x003B9036
		// (set) Token: 0x0602724D RID: 160333 RVA: 0x003BAE4A File Offset: 0x003B904A
		public unsafe FName PropertyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDelegateRuntimeBinding.__PropertyOffset_PropertyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDelegateRuntimeBinding.__PropertyOffset_PropertyName) = value;
			}
		}

		// Token: 0x17009691 RID: 38545
		// (get) Token: 0x0602724E RID: 160334 RVA: 0x003BAE5F File Offset: 0x003B905F
		// (set) Token: 0x0602724F RID: 160335 RVA: 0x003BAE73 File Offset: 0x003B9073
		public unsafe FName FunctionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDelegateRuntimeBinding.__PropertyOffset_FunctionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDelegateRuntimeBinding.__PropertyOffset_FunctionName) = value;
			}
		}

		// Token: 0x17009692 RID: 38546
		// (get) Token: 0x06027250 RID: 160336 RVA: 0x003BAE88 File Offset: 0x003B9088
		// (set) Token: 0x06027251 RID: 160337 RVA: 0x003BAECB File Offset: 0x003B90CB
		public FDynamicPropertyPath SourcePath
		{
			get
			{
				base.FastCheckIsValid();
				FDynamicPropertyPath result;
				if ((result = this._SourcePath) == null)
				{
					result = (this._SourcePath = new FDynamicPropertyPath(base.NativePtr + (IntPtr)FDelegateRuntimeBinding.__PropertyOffset_SourcePath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDynamicPropertyPath.StaticStruct(), base.NativePtr + (IntPtr)FDelegateRuntimeBinding.__PropertyOffset_SourcePath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009693 RID: 38547
		// (get) Token: 0x06027252 RID: 160338 RVA: 0x003BAEEC File Offset: 0x003B90EC
		// (set) Token: 0x06027253 RID: 160339 RVA: 0x003BAEFC File Offset: 0x003B90FC
		public unsafe EBindingKind Kind
		{
			get
			{
				return (EBindingKind)(*(base.NativePtr + (IntPtr)FDelegateRuntimeBinding.__PropertyOffset_Kind));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDelegateRuntimeBinding.__PropertyOffset_Kind) = (byte)value;
			}
		}

		// Token: 0x06027254 RID: 160340 RVA: 0x003BAF0D File Offset: 0x003B910D
		public FDelegateRuntimeBinding()
		{
		}

		// Token: 0x06027255 RID: 160341 RVA: 0x003BAF15 File Offset: 0x003B9115
		public FDelegateRuntimeBinding(string ObjectName, FName PropertyName, FName FunctionName, FDynamicPropertyPath SourcePath, EBindingKind Kind)
		{
			this.ObjectName = ObjectName;
			this.PropertyName = PropertyName;
			this.FunctionName = FunctionName;
			this.SourcePath = SourcePath;
			this.Kind = Kind;
		}

		// Token: 0x06027256 RID: 160342 RVA: 0x003BAF42 File Offset: 0x003B9142
		protected override IntPtr GetUStructPtr()
		{
			return FDelegateRuntimeBinding.StaticStruct();
		}

		// Token: 0x06027257 RID: 160343 RVA: 0x003BAF4E File Offset: 0x003B914E
		[NullableContext(2)]
		public FDelegateRuntimeBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027258 RID: 160344 RVA: 0x003BAF58 File Offset: 0x003B9158
		public FDelegateRuntimeBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027259 RID: 160345 RVA: 0x003BAF63 File Offset: 0x003B9163
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDelegateRuntimeBinding(Pointer, false, true);
		}

		// Token: 0x0602725A RID: 160346 RVA: 0x003BAF6D File Offset: 0x003B916D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDelegateRuntimeBinding(Pointer, MemoryOwner);
		}

		// Token: 0x040157EA RID: 88042
		public const string __ObjectPath = "/Script/UMG.DelegateRuntimeBinding";

		// Token: 0x040157EB RID: 88043
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040157EC RID: 88044
		internal static int __PropertyOffset_ObjectName;

		// Token: 0x040157ED RID: 88045
		internal static int __PropertyOffset_PropertyName;

		// Token: 0x040157EE RID: 88046
		internal static int __PropertyOffset_FunctionName;

		// Token: 0x040157EF RID: 88047
		internal static int __PropertyOffset_SourcePath;

		// Token: 0x040157F0 RID: 88048
		[Nullable(2)]
		private FDynamicPropertyPath _SourcePath;

		// Token: 0x040157F1 RID: 88049
		internal static int __PropertyOffset_Kind;
	}
}
