using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200091B RID: 2331
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CanvasRenderTarget2D")]
	[UnrealStructLayout(4528, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4528)]
	public class UCanvasRenderTarget2D : UTextureRenderTarget2D, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008069 RID: 32873 RVA: 0x000B8378 File Offset: 0x000B6578
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCanvasRenderTarget2D._ClassPtr;
		}

		// Token: 0x0600806A RID: 32874 RVA: 0x000B8384 File Offset: 0x000B6584
		public UCanvasRenderTarget2D() : this(BuiltinUtils.AllocNativeUObject(UCanvasRenderTarget2D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600806B RID: 32875 RVA: 0x000B83AC File Offset: 0x000B65AC
		public UCanvasRenderTarget2D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCanvasRenderTarget2D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E2D RID: 7725
		// (get) Token: 0x0600806C RID: 32876 RVA: 0x000B83E0 File Offset: 0x000B65E0
		// (set) Token: 0x0600806D RID: 32877 RVA: 0x000B8419 File Offset: 0x000B6619
		public FOnCanvasRenderTargetUpdate OnCanvasRenderTargetUpdate
		{
			get
			{
				base.FastCheckIsValid();
				FOnCanvasRenderTargetUpdate result;
				if ((result = this._OnCanvasRenderTargetUpdate) == null)
				{
					result = (this._OnCanvasRenderTargetUpdate = new FOnCanvasRenderTargetUpdate(base.NativePtr + (IntPtr)UCanvasRenderTarget2D.__PropertyOffset_OnCanvasRenderTargetUpdate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UCanvasRenderTarget2D.__PropertyOffset_OnCanvasRenderTargetUpdate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001E2E RID: 7726
		// (get) Token: 0x0600806E RID: 32878 RVA: 0x000B843A File Offset: 0x000B663A
		// (set) Token: 0x0600806F RID: 32879 RVA: 0x000B844E File Offset: 0x000B664E
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UWorld> World
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UCanvasRenderTarget2D.__PropertyOffset_World);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UCanvasRenderTarget2D.__PropertyOffset_World) = value;
			}
		}

		// Token: 0x17001E2F RID: 7727
		// (get) Token: 0x06008070 RID: 32880 RVA: 0x000B8463 File Offset: 0x000B6663
		// (set) Token: 0x06008071 RID: 32881 RVA: 0x000B8473 File Offset: 0x000B6673
		public unsafe bool bShouldClearRenderTargetOnReceiveUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCanvasRenderTarget2D.__PropertyOffset_bShouldClearRenderTargetOnReceiveUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCanvasRenderTarget2D.__PropertyOffset_bShouldClearRenderTargetOnReceiveUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x06008072 RID: 32882 RVA: 0x000B8484 File Offset: 0x000B6684
		public void UpdateResource()
		{
			UCanvasRenderTarget2D.__UpdateResource_Internal(base.NativePtr);
		}

		// Token: 0x06008073 RID: 32883 RVA: 0x000B8491 File Offset: 0x000B6691
		[NullableContext(2)]
		public virtual void ReceiveUpdate(UCanvas Canvas, int Width, int Height)
		{
			UCanvasRenderTarget2D.__ReceiveUpdate_Internal(base.NativePtr, (Canvas != null) ? Canvas.NativePtr : IntPtr.Zero, Width, Height);
		}

		// Token: 0x06008074 RID: 32884 RVA: 0x000B84B0 File Offset: 0x000B66B0
		public unsafe void GetSize(ref int Width, ref int Height)
		{
			fixed (int* ptr = &Width)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &Height)
				{
					void* ptr4 = (void*)ptr3;
					UCanvasRenderTarget2D.__GetSize_Internal(base.NativePtr, ref Width, ref Height);
					ptr = null;
				}
			}
		}

		// Token: 0x06008075 RID: 32885 RVA: 0x000B84DA File Offset: 0x000B66DA
		[NullableContext(2)]
		public static UCanvasRenderTarget2D CreateCanvasRenderTarget2D(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCanvasRenderTarget2D> CanvasRenderTarget2DClass, int Width = 1024, int Height = 1024)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCanvasRenderTarget2D>(UCanvasRenderTarget2D.__CreateCanvasRenderTarget2D_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, CanvasRenderTarget2DClass._NativePtr, Width, Height));
		}

		// Token: 0x06008076 RID: 32886
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateResource_Internal(IntPtr @this);

		// Token: 0x06008077 RID: 32887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveUpdate_Internal(IntPtr @this, IntPtr Canvas, int Width, int Height);

		// Token: 0x06008078 RID: 32888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSize_Internal(IntPtr @this, ref int Width, ref int Height);

		// Token: 0x06008079 RID: 32889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateCanvasRenderTarget2D_Internal(IntPtr WorldContextObject, IntPtr CanvasRenderTarget2DClass, int Width, int Height);

		// Token: 0x0600807A RID: 32890 RVA: 0x000B84FE File Offset: 0x000B66FE
		static UCanvasRenderTarget2D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CanvasRenderTarget2D");
		}

		// Token: 0x0600807B RID: 32891 RVA: 0x000B850C File Offset: 0x000B670C
		protected UCanvasRenderTarget2D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003D7D RID: 15741
		public new const string __ObjectPath = "/Script/Engine.CanvasRenderTarget2D";

		// Token: 0x04003D7E RID: 15742
		private static IntPtr _ClassPtr;

		// Token: 0x04003D7F RID: 15743
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003D80 RID: 15744
		internal static int __PropertyOffset_OnCanvasRenderTargetUpdate;

		// Token: 0x04003D81 RID: 15745
		[Nullable(2)]
		private FOnCanvasRenderTargetUpdate _OnCanvasRenderTargetUpdate;

		// Token: 0x04003D82 RID: 15746
		internal static int __PropertyOffset_World;

		// Token: 0x04003D83 RID: 15747
		internal static int __PropertyOffset_bShouldClearRenderTargetOnReceiveUpdate;

		// Token: 0x02002CB0 RID: 11440
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveUpdate_FunctionParams
		{
			// Token: 0x04016632 RID: 91698
			[FieldOffset(0)]
			public IntPtr Canvas;

			// Token: 0x04016633 RID: 91699
			[FieldOffset(8)]
			public int Width;

			// Token: 0x04016634 RID: 91700
			[FieldOffset(12)]
			public int Height;
		}
	}
}
