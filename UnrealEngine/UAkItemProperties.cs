using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000213 RID: 531
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkItemProperties")]
	[UnrealStructLayout(720, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 720)]
	public class UAkItemProperties : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001F8D RID: 8077 RVA: 0x0002EB4B File Offset: 0x0002CD4B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkItemProperties._ClassPtr;
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x0002EB58 File Offset: 0x0002CD58
		public UAkItemProperties() : this(BuiltinUtils.AllocNativeUObject(UAkItemProperties.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x0002EB80 File Offset: 0x0002CD80
		public UAkItemProperties(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkItemProperties.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001F90 RID: 8080 RVA: 0x0002EBB4 File Offset: 0x0002CDB4
		// (set) Token: 0x06001F91 RID: 8081 RVA: 0x0002EBED File Offset: 0x0002CDED
		public FOnItemPropertySelectionChanged OnSelectionChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnItemPropertySelectionChanged result;
				if ((result = this._OnSelectionChanged) == null)
				{
					result = (this._OnSelectionChanged = new FOnItemPropertySelectionChanged(base.NativePtr + (IntPtr)UAkItemProperties.__PropertyOffset_OnSelectionChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAkItemProperties.__PropertyOffset_OnSelectionChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001F92 RID: 8082 RVA: 0x0002EC10 File Offset: 0x0002CE10
		// (set) Token: 0x06001F93 RID: 8083 RVA: 0x0002EC49 File Offset: 0x0002CE49
		public FOnItemPropertyDragDetected OnPropertyDragged
		{
			get
			{
				base.FastCheckIsValid();
				FOnItemPropertyDragDetected result;
				if ((result = this._OnPropertyDragged) == null)
				{
					result = (this._OnPropertyDragged = new FOnItemPropertyDragDetected(base.NativePtr + (IntPtr)UAkItemProperties.__PropertyOffset_OnPropertyDragged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAkItemProperties.__PropertyOffset_OnPropertyDragged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x0002EC6C File Offset: 0x0002CE6C
		public unsafe void SetSearchText(string newText)
		{
			FString fstring = FString.AllocTemp(newText);
			UAkItemProperties.__SetSearchText_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x0002EC96 File Offset: 0x0002CE96
		public string GetSelectedProperty()
		{
			return FString.ToStringAndDeleteNativePtr(UAkItemProperties.__GetSelectedProperty_Internal(base.NativePtr));
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x0002ECA8 File Offset: 0x0002CEA8
		public string GetSearchText()
		{
			return FString.ToStringAndDeleteNativePtr(UAkItemProperties.__GetSearchText_Internal(base.NativePtr));
		}

		// Token: 0x06001F97 RID: 8087
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSearchText_Internal(IntPtr @this, in FString newText);

		// Token: 0x06001F98 RID: 8088
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSelectedProperty_Internal(IntPtr @this);

		// Token: 0x06001F99 RID: 8089
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSearchText_Internal(IntPtr @this);

		// Token: 0x06001F9A RID: 8090 RVA: 0x0002ECBA File Offset: 0x0002CEBA
		static UAkItemProperties()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkItemProperties");
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x0002ECC8 File Offset: 0x0002CEC8
		protected UAkItemProperties(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A71 RID: 2673
		public new const string __ObjectPath = "/Script/AkAudio.AkItemProperties";

		// Token: 0x04000A72 RID: 2674
		private static IntPtr _ClassPtr;

		// Token: 0x04000A73 RID: 2675
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000A74 RID: 2676
		internal static int __PropertyOffset_OnSelectionChanged;

		// Token: 0x04000A75 RID: 2677
		[Nullable(2)]
		private FOnItemPropertySelectionChanged _OnSelectionChanged;

		// Token: 0x04000A76 RID: 2678
		internal static int __PropertyOffset_OnPropertyDragged;

		// Token: 0x04000A77 RID: 2679
		[Nullable(2)]
		private FOnItemPropertyDragDetected _OnPropertyDragged;
	}
}
