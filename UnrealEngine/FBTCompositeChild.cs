using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000AF RID: 175
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTCompositeChild")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FBTCompositeChild : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06000D35 RID: 3381 RVA: 0x00014EA9 File Offset: 0x000130A9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBTCompositeChild._ScriptStructPtr != 0) ? FBTCompositeChild._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.BTCompositeChild", ref FBTCompositeChild._ScriptStructPtr);
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x00014ECD File Offset: 0x000130CD
		// (set) Token: 0x06000D37 RID: 3383 RVA: 0x00014EE1 File Offset: 0x000130E1
		public unsafe UBTCompositeNode ChildComposite
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBTCompositeNode>(base.NativePtr / (IntPtr)sizeof(void*) + FBTCompositeChild.__PropertyOffset_ChildComposite);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBTCompositeChild.__PropertyOffset_ChildComposite, value);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x00014EF6 File Offset: 0x000130F6
		// (set) Token: 0x06000D39 RID: 3385 RVA: 0x00014F0A File Offset: 0x0001310A
		public unsafe UBTTaskNode ChildTask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBTTaskNode>(base.NativePtr / (IntPtr)sizeof(void*) + FBTCompositeChild.__PropertyOffset_ChildTask);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBTCompositeChild.__PropertyOffset_ChildTask, value);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x00014F20 File Offset: 0x00013120
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x00014F63 File Offset: 0x00013163
		[Nullable(1)]
		public TArray<UBTDecorator> Decorators
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UBTDecorator> result;
				if ((result = this._Decorators) == null)
				{
					result = (this._Decorators = new TArray<UBTDecorator>(base.NativePtr + (IntPtr)FBTCompositeChild.__PropertyOffset_Decorators, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Decorators.CopyAssign(value);
			}
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00014F71 File Offset: 0x00013171
		public FBTCompositeChild()
		{
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00014F79 File Offset: 0x00013179
		protected override IntPtr GetUStructPtr()
		{
			return FBTCompositeChild.StaticStruct();
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00014F85 File Offset: 0x00013185
		public FBTCompositeChild(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00014F8F File Offset: 0x0001318F
		public FBTCompositeChild(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00014F9A File Offset: 0x0001319A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBTCompositeChild(Pointer, false, true);
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00014FA4 File Offset: 0x000131A4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBTCompositeChild(Pointer, MemoryOwner);
		}

		// Token: 0x04000249 RID: 585
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.BTCompositeChild";

		// Token: 0x0400024A RID: 586
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400024B RID: 587
		internal static int __PropertyOffset_ChildComposite;

		// Token: 0x0400024C RID: 588
		internal static int __PropertyOffset_ChildTask;

		// Token: 0x0400024D RID: 589
		internal static int __PropertyOffset_Decorators;

		// Token: 0x0400024E RID: 590
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBTDecorator> _Decorators;
	}
}
