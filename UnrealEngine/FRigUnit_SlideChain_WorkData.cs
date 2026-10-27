using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006D7 RID: 1751
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SlideChain_WorkData")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FRigUnit_SlideChain_WorkData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005DC8 RID: 24008 RVA: 0x000869C5 File Offset: 0x00084BC5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SlideChain_WorkData._ScriptStructPtr != 0) ? FRigUnit_SlideChain_WorkData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SlideChain_WorkData", ref FRigUnit_SlideChain_WorkData._ScriptStructPtr);
		}

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x06005DC9 RID: 24009 RVA: 0x000869E9 File Offset: 0x00084BE9
		// (set) Token: 0x06005DCA RID: 24010 RVA: 0x000869F9 File Offset: 0x00084BF9
		public unsafe float ChainLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SlideChain_WorkData.__PropertyOffset_ChainLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SlideChain_WorkData.__PropertyOffset_ChainLength) = value;
			}
		}

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x06005DCB RID: 24011 RVA: 0x00086A0C File Offset: 0x00084C0C
		// (set) Token: 0x06005DCC RID: 24012 RVA: 0x00086A4F File Offset: 0x00084C4F
		public TArray<float> ItemSegments
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ItemSegments) == null)
				{
					result = (this._ItemSegments = new TArray<float>(base.NativePtr + (IntPtr)FRigUnit_SlideChain_WorkData.__PropertyOffset_ItemSegments, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ItemSegments.CopyAssign(value);
			}
		}

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x06005DCD RID: 24013 RVA: 0x00086A60 File Offset: 0x00084C60
		// (set) Token: 0x06005DCE RID: 24014 RVA: 0x00086AA3 File Offset: 0x00084CA3
		public TArray<FCachedRigElement> CachedItems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCachedRigElement> result;
				if ((result = this._CachedItems) == null)
				{
					result = (this._CachedItems = new TArray<FCachedRigElement>(base.NativePtr + (IntPtr)FRigUnit_SlideChain_WorkData.__PropertyOffset_CachedItems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CachedItems.CopyAssign(value);
			}
		}

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x06005DCF RID: 24015 RVA: 0x00086AB4 File Offset: 0x00084CB4
		// (set) Token: 0x06005DD0 RID: 24016 RVA: 0x00086AF7 File Offset: 0x00084CF7
		public TArray<FTransform> Transforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._Transforms) == null)
				{
					result = (this._Transforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FRigUnit_SlideChain_WorkData.__PropertyOffset_Transforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Transforms.CopyAssign(value);
			}
		}

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x06005DD1 RID: 24017 RVA: 0x00086B08 File Offset: 0x00084D08
		// (set) Token: 0x06005DD2 RID: 24018 RVA: 0x00086B4B File Offset: 0x00084D4B
		public TArray<FTransform> BlendedTransforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._BlendedTransforms) == null)
				{
					result = (this._BlendedTransforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FRigUnit_SlideChain_WorkData.__PropertyOffset_BlendedTransforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BlendedTransforms.CopyAssign(value);
			}
		}

		// Token: 0x06005DD3 RID: 24019 RVA: 0x00086B59 File Offset: 0x00084D59
		public FRigUnit_SlideChain_WorkData()
		{
		}

		// Token: 0x06005DD4 RID: 24020 RVA: 0x00086B61 File Offset: 0x00084D61
		public FRigUnit_SlideChain_WorkData(float ChainLength, TArray<float> ItemSegments, TArray<FCachedRigElement> CachedItems, TArray<FTransform> Transforms, TArray<FTransform> BlendedTransforms)
		{
			this.ChainLength = ChainLength;
			this.ItemSegments = ItemSegments;
			this.CachedItems = CachedItems;
			this.Transforms = Transforms;
			this.BlendedTransforms = BlendedTransforms;
		}

		// Token: 0x06005DD5 RID: 24021 RVA: 0x00086B8E File Offset: 0x00084D8E
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SlideChain_WorkData.StaticStruct();
		}

		// Token: 0x06005DD6 RID: 24022 RVA: 0x00086B9A File Offset: 0x00084D9A
		[NullableContext(2)]
		public FRigUnit_SlideChain_WorkData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005DD7 RID: 24023 RVA: 0x00086BA4 File Offset: 0x00084DA4
		public FRigUnit_SlideChain_WorkData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005DD8 RID: 24024 RVA: 0x00086BAF File Offset: 0x00084DAF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SlideChain_WorkData(Pointer, false, true);
		}

		// Token: 0x06005DD9 RID: 24025 RVA: 0x00086BB9 File Offset: 0x00084DB9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SlideChain_WorkData(Pointer, MemoryOwner);
		}

		// Token: 0x04002BE1 RID: 11233
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_SlideChain_WorkData";

		// Token: 0x04002BE2 RID: 11234
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002BE3 RID: 11235
		internal static int __PropertyOffset_ChainLength;

		// Token: 0x04002BE4 RID: 11236
		internal static int __PropertyOffset_ItemSegments;

		// Token: 0x04002BE5 RID: 11237
		[Nullable(2)]
		private TArray<float> _ItemSegments;

		// Token: 0x04002BE6 RID: 11238
		internal static int __PropertyOffset_CachedItems;

		// Token: 0x04002BE7 RID: 11239
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCachedRigElement> _CachedItems;

		// Token: 0x04002BE8 RID: 11240
		internal static int __PropertyOffset_Transforms;

		// Token: 0x04002BE9 RID: 11241
		[Nullable(2)]
		private TArray<FTransform> _Transforms;

		// Token: 0x04002BEA RID: 11242
		internal static int __PropertyOffset_BlendedTransforms;

		// Token: 0x04002BEB RID: 11243
		[Nullable(2)]
		private TArray<FTransform> _BlendedTransforms;
	}
}
