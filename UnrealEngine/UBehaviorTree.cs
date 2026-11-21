using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000AB RID: 171
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BehaviorTree")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UBehaviorTree : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000D08 RID: 3336 RVA: 0x00014B39 File Offset: 0x00012D39
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBehaviorTree._ClassPtr;
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00014B48 File Offset: 0x00012D48
		public UBehaviorTree() : this(BuiltinUtils.AllocNativeUObject(UBehaviorTree.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00014B70 File Offset: 0x00012D70
		public UBehaviorTree(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBehaviorTree.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x00014BA3 File Offset: 0x00012DA3
		// (set) Token: 0x06000D0C RID: 3340 RVA: 0x00014BB7 File Offset: 0x00012DB7
		[Nullable(2)]
		public unsafe UBTCompositeNode RootNode
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBTCompositeNode>(base.NativePtr / (IntPtr)sizeof(void*) + UBehaviorTree.__PropertyOffset_RootNode);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBehaviorTree.__PropertyOffset_RootNode, value);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x00014BCC File Offset: 0x00012DCC
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x00014C05 File Offset: 0x00012E05
		public TArray<UBTDecorator> RootDecorators
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBTDecorator> result;
				if ((result = this._RootDecorators) == null)
				{
					result = (this._RootDecorators = new TArray<UBTDecorator>(base.NativePtr + (IntPtr)UBehaviorTree.__PropertyOffset_RootDecorators, this));
				}
				return result;
			}
			set
			{
				this.RootDecorators.CopyAssign(value);
			}
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00014C13 File Offset: 0x00012E13
		static UBehaviorTree()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BehaviorTree");
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x00014C21 File Offset: 0x00012E21
		protected UBehaviorTree(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000236 RID: 566
		public new const string __ObjectPath = "/Script/AIModule.BehaviorTree";

		// Token: 0x04000237 RID: 567
		private static IntPtr _ClassPtr;

		// Token: 0x04000238 RID: 568
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000239 RID: 569
		internal static int __PropertyOffset_RootNode;

		// Token: 0x0400023A RID: 570
		internal static int __PropertyOffset_RootDecorators;

		// Token: 0x0400023B RID: 571
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBTDecorator> _RootDecorators;
	}
}
