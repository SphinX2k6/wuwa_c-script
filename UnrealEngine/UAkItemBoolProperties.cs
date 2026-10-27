using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000211 RID: 529
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkItemBoolProperties")]
	[UnrealStructLayout(720, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 720)]
	public class UAkItemBoolProperties : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001F75 RID: 8053 RVA: 0x0002E90A File Offset: 0x0002CB0A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkItemBoolProperties._ClassPtr;
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x0002E918 File Offset: 0x0002CB18
		public UAkItemBoolProperties() : this(BuiltinUtils.AllocNativeUObject(UAkItemBoolProperties.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x0002E940 File Offset: 0x0002CB40
		public UAkItemBoolProperties(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkItemBoolProperties.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001F78 RID: 8056 RVA: 0x0002E974 File Offset: 0x0002CB74
		// (set) Token: 0x06001F79 RID: 8057 RVA: 0x0002E9AD File Offset: 0x0002CBAD
		public FOnItemBoolPropertySelectionChanged OnSelectionChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnItemBoolPropertySelectionChanged result;
				if ((result = this._OnSelectionChanged) == null)
				{
					result = (this._OnSelectionChanged = new FOnItemBoolPropertySelectionChanged(base.NativePtr + (IntPtr)UAkItemBoolProperties.__PropertyOffset_OnSelectionChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAkItemBoolProperties.__PropertyOffset_OnSelectionChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001F7A RID: 8058 RVA: 0x0002E9D0 File Offset: 0x0002CBD0
		// (set) Token: 0x06001F7B RID: 8059 RVA: 0x0002EA09 File Offset: 0x0002CC09
		public FOnItemBoolPropertyDragDetected OnPropertyDragged
		{
			get
			{
				base.FastCheckIsValid();
				FOnItemBoolPropertyDragDetected result;
				if ((result = this._OnPropertyDragged) == null)
				{
					result = (this._OnPropertyDragged = new FOnItemBoolPropertyDragDetected(base.NativePtr + (IntPtr)UAkItemBoolProperties.__PropertyOffset_OnPropertyDragged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAkItemBoolProperties.__PropertyOffset_OnPropertyDragged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x0002EA2C File Offset: 0x0002CC2C
		public unsafe void SetSearchText(string newText)
		{
			FString fstring = FString.AllocTemp(newText);
			UAkItemBoolProperties.__SetSearchText_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x0002EA56 File Offset: 0x0002CC56
		public string GetSelectedProperty()
		{
			return FString.ToStringAndDeleteNativePtr(UAkItemBoolProperties.__GetSelectedProperty_Internal(base.NativePtr));
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x0002EA68 File Offset: 0x0002CC68
		public string GetSearchText()
		{
			return FString.ToStringAndDeleteNativePtr(UAkItemBoolProperties.__GetSearchText_Internal(base.NativePtr));
		}

		// Token: 0x06001F7F RID: 8063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSearchText_Internal(IntPtr @this, in FString newText);

		// Token: 0x06001F80 RID: 8064
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSelectedProperty_Internal(IntPtr @this);

		// Token: 0x06001F81 RID: 8065
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSearchText_Internal(IntPtr @this);

		// Token: 0x06001F82 RID: 8066 RVA: 0x0002EA7A File Offset: 0x0002CC7A
		static UAkItemBoolProperties()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkItemBoolProperties");
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x0002EA88 File Offset: 0x0002CC88
		protected UAkItemBoolProperties(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A67 RID: 2663
		public new const string __ObjectPath = "/Script/AkAudio.AkItemBoolProperties";

		// Token: 0x04000A68 RID: 2664
		private static IntPtr _ClassPtr;

		// Token: 0x04000A69 RID: 2665
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000A6A RID: 2666
		internal static int __PropertyOffset_OnSelectionChanged;

		// Token: 0x04000A6B RID: 2667
		[Nullable(2)]
		private FOnItemBoolPropertySelectionChanged _OnSelectionChanged;

		// Token: 0x04000A6C RID: 2668
		internal static int __PropertyOffset_OnPropertyDragged;

		// Token: 0x04000A6D RID: 2669
		[Nullable(2)]
		private FOnItemBoolPropertyDragDetected _OnPropertyDragged;
	}
}
