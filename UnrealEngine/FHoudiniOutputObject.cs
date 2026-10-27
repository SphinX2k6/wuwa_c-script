using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014E6 RID: 5350
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniOutputObject")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 248)]
	public class FHoudiniOutputObject : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060135E7 RID: 79335 RVA: 0x001C7B66 File Offset: 0x001C5D66
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniOutputObject._ScriptStructPtr != 0) ? FHoudiniOutputObject._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniOutputObject", ref FHoudiniOutputObject._ScriptStructPtr);
		}

		// Token: 0x17004B83 RID: 19331
		// (get) Token: 0x060135E8 RID: 79336 RVA: 0x001C7B8A File Offset: 0x001C5D8A
		// (set) Token: 0x060135E9 RID: 79337 RVA: 0x001C7B9E File Offset: 0x001C5D9E
		[Nullable(2)]
		public unsafe UObject OutputObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FHoudiniOutputObject.__PropertyOffset_OutputObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FHoudiniOutputObject.__PropertyOffset_OutputObject, value);
			}
		}

		// Token: 0x17004B84 RID: 19332
		// (get) Token: 0x060135EA RID: 79338 RVA: 0x001C7BB3 File Offset: 0x001C5DB3
		// (set) Token: 0x060135EB RID: 79339 RVA: 0x001C7BC7 File Offset: 0x001C5DC7
		[Nullable(2)]
		public unsafe UObject OutputComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FHoudiniOutputObject.__PropertyOffset_OutputComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FHoudiniOutputObject.__PropertyOffset_OutputComponent, value);
			}
		}

		// Token: 0x17004B85 RID: 19333
		// (get) Token: 0x060135EC RID: 79340 RVA: 0x001C7BDC File Offset: 0x001C5DDC
		// (set) Token: 0x060135ED RID: 79341 RVA: 0x001C7BF0 File Offset: 0x001C5DF0
		[Nullable(2)]
		public unsafe UObject ProxyObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FHoudiniOutputObject.__PropertyOffset_ProxyObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FHoudiniOutputObject.__PropertyOffset_ProxyObject, value);
			}
		}

		// Token: 0x17004B86 RID: 19334
		// (get) Token: 0x060135EE RID: 79342 RVA: 0x001C7C05 File Offset: 0x001C5E05
		// (set) Token: 0x060135EF RID: 79343 RVA: 0x001C7C19 File Offset: 0x001C5E19
		[Nullable(2)]
		public unsafe UObject ProxyComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FHoudiniOutputObject.__PropertyOffset_ProxyComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FHoudiniOutputObject.__PropertyOffset_ProxyComponent, value);
			}
		}

		// Token: 0x17004B87 RID: 19335
		// (get) Token: 0x060135F0 RID: 79344 RVA: 0x001C7C2E File Offset: 0x001C5E2E
		// (set) Token: 0x060135F1 RID: 79345 RVA: 0x001C7C3E File Offset: 0x001C5E3E
		public unsafe bool bProxyIsCurrent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniOutputObject.__PropertyOffset_bProxyIsCurrent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniOutputObject.__PropertyOffset_bProxyIsCurrent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B88 RID: 19336
		// (get) Token: 0x060135F2 RID: 79346 RVA: 0x001C7C4F File Offset: 0x001C5E4F
		// (set) Token: 0x060135F3 RID: 79347 RVA: 0x001C7C5F File Offset: 0x001C5E5F
		public unsafe bool bIsImplicit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniOutputObject.__PropertyOffset_bIsImplicit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniOutputObject.__PropertyOffset_bIsImplicit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B89 RID: 19337
		// (get) Token: 0x060135F4 RID: 79348 RVA: 0x001C7C70 File Offset: 0x001C5E70
		// (set) Token: 0x060135F5 RID: 79349 RVA: 0x001C7C80 File Offset: 0x001C5E80
		public unsafe bool bIsGeometryCollectionPiece
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniOutputObject.__PropertyOffset_bIsGeometryCollectionPiece) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniOutputObject.__PropertyOffset_bIsGeometryCollectionPiece) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B8A RID: 19338
		// (get) Token: 0x060135F6 RID: 79350 RVA: 0x001C7C91 File Offset: 0x001C5E91
		// (set) Token: 0x060135F7 RID: 79351 RVA: 0x001C7CA5 File Offset: 0x001C5EA5
		public unsafe string GeometryCollectionPieceName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniOutputObject.__PropertyOffset_GeometryCollectionPieceName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniOutputObject.__PropertyOffset_GeometryCollectionPieceName)), value);
			}
		}

		// Token: 0x17004B8B RID: 19339
		// (get) Token: 0x060135F8 RID: 79352 RVA: 0x001C7CBA File Offset: 0x001C5EBA
		// (set) Token: 0x060135F9 RID: 79353 RVA: 0x001C7CCE File Offset: 0x001C5ECE
		public unsafe string BakeName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniOutputObject.__PropertyOffset_BakeName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniOutputObject.__PropertyOffset_BakeName)), value);
			}
		}

		// Token: 0x17004B8C RID: 19340
		// (get) Token: 0x060135FA RID: 79354 RVA: 0x001C7CE4 File Offset: 0x001C5EE4
		// (set) Token: 0x060135FB RID: 79355 RVA: 0x001C7D27 File Offset: 0x001C5F27
		public FHoudiniCurveOutputProperties CurveOutputProperty
		{
			get
			{
				base.FastCheckIsValid();
				FHoudiniCurveOutputProperties result;
				if ((result = this._CurveOutputProperty) == null)
				{
					result = (this._CurveOutputProperty = new FHoudiniCurveOutputProperties(base.NativePtr + (IntPtr)FHoudiniOutputObject.__PropertyOffset_CurveOutputProperty, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHoudiniCurveOutputProperties.StaticStruct(), base.NativePtr + (IntPtr)FHoudiniOutputObject.__PropertyOffset_CurveOutputProperty, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004B8D RID: 19341
		// (get) Token: 0x060135FC RID: 79356 RVA: 0x001C7D48 File Offset: 0x001C5F48
		// (set) Token: 0x060135FD RID: 79357 RVA: 0x001C7D8B File Offset: 0x001C5F8B
		public TMap<string, string> CachedAttributes
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._CachedAttributes) == null)
				{
					result = (this._CachedAttributes = new TMap<string, string>(base.NativePtr + (IntPtr)FHoudiniOutputObject.__PropertyOffset_CachedAttributes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CachedAttributes.CopyAssign(value);
			}
		}

		// Token: 0x17004B8E RID: 19342
		// (get) Token: 0x060135FE RID: 79358 RVA: 0x001C7D9C File Offset: 0x001C5F9C
		// (set) Token: 0x060135FF RID: 79359 RVA: 0x001C7DDF File Offset: 0x001C5FDF
		public TMap<string, string> CachedTokens
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._CachedTokens) == null)
				{
					result = (this._CachedTokens = new TMap<string, string>(base.NativePtr + (IntPtr)FHoudiniOutputObject.__PropertyOffset_CachedTokens, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CachedTokens.CopyAssign(value);
			}
		}

		// Token: 0x06013600 RID: 79360 RVA: 0x001C7DED File Offset: 0x001C5FED
		public FHoudiniOutputObject()
		{
		}

		// Token: 0x06013601 RID: 79361 RVA: 0x001C7DF8 File Offset: 0x001C5FF8
		public FHoudiniOutputObject(UObject OutputObject, UObject OutputComponent, UObject ProxyObject, UObject ProxyComponent, bool bProxyIsCurrent, bool bIsImplicit, bool bIsGeometryCollectionPiece, string GeometryCollectionPieceName, string BakeName, FHoudiniCurveOutputProperties CurveOutputProperty, TMap<string, string> CachedAttributes, TMap<string, string> CachedTokens)
		{
			this.OutputObject = OutputObject;
			this.OutputComponent = OutputComponent;
			this.ProxyObject = ProxyObject;
			this.ProxyComponent = ProxyComponent;
			this.bProxyIsCurrent = bProxyIsCurrent;
			this.bIsImplicit = bIsImplicit;
			this.bIsGeometryCollectionPiece = bIsGeometryCollectionPiece;
			this.GeometryCollectionPieceName = GeometryCollectionPieceName;
			this.BakeName = BakeName;
			this.CurveOutputProperty = CurveOutputProperty;
			this.CachedAttributes = CachedAttributes;
			this.CachedTokens = CachedTokens;
		}

		// Token: 0x06013602 RID: 79362 RVA: 0x001C7E68 File Offset: 0x001C6068
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniOutputObject.StaticStruct();
		}

		// Token: 0x06013603 RID: 79363 RVA: 0x001C7E74 File Offset: 0x001C6074
		[NullableContext(2)]
		public FHoudiniOutputObject(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013604 RID: 79364 RVA: 0x001C7E7E File Offset: 0x001C607E
		public FHoudiniOutputObject(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013605 RID: 79365 RVA: 0x001C7E89 File Offset: 0x001C6089
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniOutputObject(Pointer, false, true);
		}

		// Token: 0x06013606 RID: 79366 RVA: 0x001C7E93 File Offset: 0x001C6093
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniOutputObject(Pointer, MemoryOwner);
		}

		// Token: 0x0400A771 RID: 42865
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniOutputObject";

		// Token: 0x0400A772 RID: 42866
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A773 RID: 42867
		internal static int __PropertyOffset_OutputObject;

		// Token: 0x0400A774 RID: 42868
		internal static int __PropertyOffset_OutputComponent;

		// Token: 0x0400A775 RID: 42869
		internal static int __PropertyOffset_ProxyObject;

		// Token: 0x0400A776 RID: 42870
		internal static int __PropertyOffset_ProxyComponent;

		// Token: 0x0400A777 RID: 42871
		internal static int __PropertyOffset_bProxyIsCurrent;

		// Token: 0x0400A778 RID: 42872
		internal static int __PropertyOffset_bIsImplicit;

		// Token: 0x0400A779 RID: 42873
		internal static int __PropertyOffset_bIsGeometryCollectionPiece;

		// Token: 0x0400A77A RID: 42874
		internal static int __PropertyOffset_GeometryCollectionPieceName;

		// Token: 0x0400A77B RID: 42875
		internal static int __PropertyOffset_BakeName;

		// Token: 0x0400A77C RID: 42876
		internal static int __PropertyOffset_CurveOutputProperty;

		// Token: 0x0400A77D RID: 42877
		[Nullable(2)]
		private FHoudiniCurveOutputProperties _CurveOutputProperty;

		// Token: 0x0400A77E RID: 42878
		internal static int __PropertyOffset_CachedAttributes;

		// Token: 0x0400A77F RID: 42879
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _CachedAttributes;

		// Token: 0x0400A780 RID: 42880
		internal static int __PropertyOffset_CachedTokens;

		// Token: 0x0400A781 RID: 42881
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _CachedTokens;
	}
}
